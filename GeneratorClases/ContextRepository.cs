using Humanizer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.GeneratorClases
{
    class ContextRepository
    {

        private SchemaRepository schema;
        private IEnumerable<DatabaseTable> tables;
        public ContextRepository(SchemaRepository schema)
        {
            this.schema = schema;
            tables = schema.ListTables();
        }

        public string GetContextString(string databaseName)
        {
            return buildContextClass(databaseName);
        }

        public string buildContextClass(string databaseName)
        {
            var sb = new StringBuilder();
            sb.GetUsings()
                .GetNamespace("GeneratedContext")
                .GetClass(databaseName, "AuditContext")
                .AppendLine($"public {databaseName}()")
                .AppendLine($": base(\"name = {databaseName}\")")
                .AppendLine("{")
                .AppendLine("}");
            sb.AppendLine(GetEntitySets(tables));
            sb.AppendLine(GetOnModelCreatingFunction(tables));
            sb.GetClassEnd()
             .GetNamespaceEnd();
            return sb.ToString();
        }

        public string GetEntitySets(IEnumerable<DatabaseTable> tables)
        {
            var sb = new StringBuilder();
            foreach (var table in tables)
            {
                if (table.Name.ToLower().EndsWith("person"))
                {
                    sb.AppendLine($"public virtual DbSet<{table.Name}> {table.Name}s {{ get; set; }}");
                    sb.AppendLine($"public virtual DbSet<{table.Name}Audit> {(table.Name + "Audit")}s {{ get; set; }}");
                }
                else
                {
                    sb.AppendLine($"public virtual DbSet<{table.Name}> {table.Name.Pluralize()} {{ get; set; }}");
                    sb.AppendLine($"public virtual DbSet<{table.Name}Audit> {(table.Name + "Audit").Pluralize()} {{ get; set; }}");
                }

            }
            return sb.ToString();
        }
        public string GetOnModelCreatingFunction(IEnumerable<DatabaseTable> tables)
        {
            var sb = new StringBuilder();
            sb.AppendLine("protected override void OnModelCreating(DbModelBuilder modelBuilder)")
                  .AppendLine("{").ToString();
            foreach (var table in tables)
            {
                foreach (var colum in table.Columns.Where(e => e.DataType.ToLower() == "varchar"))
                {
                    sb.AppendLine($"modelBuilder.Entity<{table.Name}>()")
                   .AppendLine($".Property(e => e.{colum.Name.Dehumanize()})")
                   .AppendLine(".IsUnicode(false);");
                }
                sb.AppendLine($"RegisterAuditType(typeof({table.Name}), typeof({table.Name}Audit));");
            }
            sb.GetFunctionEnd();
            return sb.ToString();
        }

        public string GetEntityClasses()
        {
            var sb = new StringBuilder();
            //sb.GetUsings();

            sb.GetNamespace("GeneratedContext");
            GetIAuditInterface(sb);
            GetIAuditableInterface(sb);
            GetAuditTypeInfo(sb);
            GetAuditContext(sb);
            foreach (var table in tables)
            {
                //Regular Tables
                GetRegularTables(sb, table);
                //Audit Tables
                GetAuditTables(sb, table);
            }
            sb.GetNamespaceEnd();
            return sb.ToString();
        }

        private static void GetIAuditInterface(StringBuilder sb)
        {
            sb.AppendLine(" public interface IAudit");
            sb.AppendLine("{");
            sb.AppendLine("DateTime StampDate { get; set; }");
            sb.AppendLine("string StampUser { get; set; }");
            sb.AppendLine("string StampAction { get; set; }");
            sb.AppendLine("int StampID { get; set; }");
            sb.AppendLine("}");
        }
        private static void GetIAuditableInterface(StringBuilder sb)
        {
            sb.AppendLine(" public interface IAuditable");
            sb.AppendLine("{");
            sb.AppendLine("int ID {get;set;}");
            sb.AppendLine("}");
        }

        private static void GetAuditTypeInfo(StringBuilder sb)
        {
            sb.AppendLine("internal class AuditTypeInfo");
            sb.AppendLine("{");
            sb.AppendLine("internal AuditTypeInfo()");
            sb.AppendLine("{");
            sb.AppendLine("this.AuditProperties = new Collection<string>();");
            sb.AppendLine("}");
            sb.AppendLine("internal Type EntityType { get; set; }");
            sb.AppendLine("internal Type AuditEntityType { get; set; }");
            sb.AppendLine("internal Collection<string> AuditProperties { get; set; }");
            sb.AppendLine("}");
        }
        private static void GetAuditTables(StringBuilder sb, DatabaseTable table)
        {
            sb.AppendLine($"[Table(\"{table.Name}Audit\")]")
            .GetClass($"{table.Name}Audit", "IAudit");
            sb.GetConstructor(table, isAudit: true);
            foreach (var column in table.Columns)
            {
                sb.GetProperty(column);
            }
            sb.AppendLine("public int StampID {get;set;}");
            sb.AppendLine("public DateTime StampDate {get;set;}");
            sb.AppendLine("[Column(TypeName = \"char\")]");
            sb.AppendLine("public string StampAction {get;set;}");
            if (table.Columns.All(e => e.Name.ToLower() != "stampuser"))
            {
                sb.AppendLine("public string StampUser {get;set;}");
            }
            sb.GetClassEnd();
        }

        private static void GetRegularTables(StringBuilder sb, DatabaseTable table)
        {
            sb.AppendLine($"[Table(\"{table.Name}\")]");
            sb.GetClass($"{table.Name}", "IAuditable");
            sb.GetConstructor(table);
            foreach (var column in table.Columns)
            {
                sb.GetProperty(column);
            }
            foreach (var navProp in table.NavigationProperties)
            {
                var relatedTable = navProp.RelatedTable;
                if (string.Equals(relatedTable, table.Name, StringComparison.CurrentCultureIgnoreCase))
                {
                    relatedTable = $"Super{relatedTable}";
                }
                if (navProp.RelationshipType == "One")
                {
                    sb.AppendLine($"[ForeignKey(\"{navProp.Column.Dehumanize()}\")]");
                    sb.AppendLine($"public virtual {navProp.RelatedTable} {relatedTable}" + "{get; set;}");
                }
                else
                {
                    sb.AppendLine($"[ForeignKey(\"{navProp.RelatedColumn.Dehumanize()}\")]");
                    sb.AppendLine($"public virtual ICollection<{navProp.RelatedTable}> {navProp.RelatedTable}s" + "{get; set;}");
                }
            }
            sb.GetClassEnd();
        }

        private static void GetAuditContext(StringBuilder sb)
        {
            sb.AppendLine("public class AuditContext : DbContext");
            sb.AppendLine("{");
            sb.AppendLine("private const string AuditActionColumnName = \"StampAction\";");
            sb.AppendLine("private const string AuditStampUserColumnName = \"StampUser\";");
            sb.AppendLine("private const string AuditStampDateColumnName = \"StampDate\";");
            sb.AppendLine("private const string AuditStampIDColumnName = \"StampID\";");
            sb.AppendLine("");
            sb.AppendLine("private static Dictionary<Type, AuditTypeInfo> auditTypes = new Dictionary<Type, AuditTypeInfo>();");
            sb.AppendLine("");
            sb.AppendLine("#region Constructors");
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Initializes a new instance of the AuditDbContext class");
            sb.AppendLine("/// using the given string as the name or connection string");
            sb.AppendLine("/// for the database to which a connection will be made.");
            sb.AppendLine("/// </summary>");
            sb.AppendLine("/// <param name=\"nameOrConnectionString\">Either the database name or the connection string.</param>");
            sb.AppendLine("public AuditContext(string nameOrConnectionString)");
            sb.AppendLine(": base(nameOrConnectionString)");
            sb.AppendLine("{");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("#endregion Constructors");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("public static bool AuditEnabled { get; private set; }");
            sb.AppendLine("");
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Registers and type for auditing.");
            sb.AppendLine("/// </summary>");
            sb.AppendLine("/// <param name=\"auditableEntityType\">Type to audit, must implement IAuditable.</param>");
            sb.AppendLine("/// <param name=\"auditEntityType\">Type of audit entity, must implement IAudit.</param>");
            sb.AppendLine("public static void RegisterAuditType(Type auditableEntityType, Type auditEntityType)");
            sb.AppendLine("{");
            sb.AppendLine("AuditEnabled = true;");
            sb.AppendLine("// Basic parameter validation.");
            sb.AppendLine("if (auditableEntityType == null)");
            sb.AppendLine("{");
            sb.AppendLine("throw new ArgumentNullException(\"auditableEntityType\");");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("if (auditTypes.ContainsKey(auditableEntityType))");
            sb.AppendLine("{");
            sb.AppendLine("return;");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("// Validate the entity.");
            sb.AppendLine("var iface = auditableEntityType.GetInterface(\"IAuditable\");");
            sb.AppendLine("if (iface == null)");
            sb.AppendLine("{");
            sb.AppendLine("throw new ArgumentException(\"Entity does implement IAuditable\", \"auditableEntityType\");");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("AuditTypeInfo info = new AuditTypeInfo { EntityType = auditableEntityType, AuditEntityType = auditEntityType };");
            sb.AppendLine("");
            sb.AppendLine("// Validate the auditEntity");
            sb.AppendLine("if (auditEntityType != null)");
            sb.AppendLine("{");
            sb.AppendLine("iface = auditEntityType.GetInterface(\"IAudit\");");
            sb.AppendLine("if (iface == null)");
            sb.AppendLine("{");
            sb.AppendLine("throw new ArgumentException(\"Entity does implement IAudit\", \"auditEntityType\");");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("// Extract the list of properties to audit.");
            sb.AppendLine("var properties = auditEntityType.GetProperties();");
            sb.AppendLine("var entityProperties = auditableEntityType.GetProperties().ToDictionary(x => x.Name);");
            sb.AppendLine("foreach (var property in properties)");
            sb.AppendLine("{");
            sb.AppendLine("if (entityProperties.ContainsKey(property.Name))");
            sb.AppendLine("{");
            sb.AppendLine("if (property.PropertyType == entityProperties[property.Name].PropertyType)");
            sb.AppendLine("{");
            sb.AppendLine("info.AuditProperties.Add(property.Name);");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("// Valid so register.");
            sb.AppendLine("auditTypes.Add(auditableEntityType, info);");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Reloads the entity from the database overwriting any property values with values from the database.");
            sb.AppendLine("/// The entity will be in the Unchanged state after calling this method.");
            sb.AppendLine("/// </summary>");
            sb.AppendLine("/// <param name=\"entity\">The entity object to reload.</param>");
            sb.AppendLine("public void Reload(object entity)");
            sb.AppendLine("{");
            sb.AppendLine("this.Entry(entity).Reload();");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Saves all changes made in this context to the underlying database");
            sb.AppendLine("/// using the current windows user for auditing.");
            sb.AppendLine("/// </summary>");
            sb.AppendLine("/// <returns>The number of objects written to the underlying database.</returns>");
            sb.AppendLine("public override int SaveChanges()");
            sb.AppendLine("{");
            sb.AppendLine("return this.SaveChanges(WindowsIdentity.GetCurrent().Name);");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Saves all changes made in this context to the underlying database");
            sb.AppendLine("/// using the user parameter passed for auditing.");
            sb.AppendLine("/// </summary>");
            sb.AppendLine("/// <param name=\"user\">User name for auditing.</param>");
            sb.AppendLine("/// <returns>The number of objects written to the underlying database.</returns>");
            sb.AppendLine("    public int SaveChanges(string user)");
            sb.AppendLine(" {");
            sb.AppendLine("if (AuditEnabled)");
            sb.AppendLine("{");
            sb.AppendLine("    // Track all audit entities created in this transaction, will be removed from context on exception.");
            sb.AppendLine("    List<IAudit> audits = new List<IAudit>();");
            sb.AppendLine("");
            sb.AppendLine("// Use the same datetime for all updates in this transaction, retrieved from server when first used.");
            sb.AppendLine("DateTime? updateDateTime = null;");
            sb.AppendLine("");
            sb.AppendLine("// Process any audit-able objects.");
            sb.AppendLine("foreach (DbEntityEntry<IAuditable> auditable in this.ChangeTracker.Entries<IAuditable>())");
            sb.AppendLine("{");
            sb.AppendLine("if (auditable.State == EntityState.Added");
            sb.AppendLine("|| auditable.State == EntityState.Modified");
            sb.AppendLine("|| auditable.State == EntityState.Deleted)");
            sb.AppendLine("{");
            sb.AppendLine("    // Need datetime for the audits.");
            sb.AppendLine("    if (updateDateTime.HasValue == false)");
            sb.AppendLine("    {");
            sb.AppendLine("        updateDateTime = DateTime.Now;");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("// Create an audit entity.");
            sb.AppendLine("if (auditable.State == EntityState.Modified");
            sb.AppendLine(" || auditable.State == EntityState.Added)");
            sb.AppendLine("{");
            sb.AppendLine("    // TODO: Find a better way of doing this proxy check.");
            sb.AppendLine("    Type entityType = auditable.Entity.GetType();");
            sb.AppendLine("    if (auditTypes.ContainsKey(entityType) && auditTypes[entityType].AuditEntityType != null)");
            sb.AppendLine("    {");
            sb.AppendLine("        audits.Add(this.AuditEntity(auditable, auditTypes[entityType], updateDateTime.Value, user));");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("else if (auditable.State == EntityState.Deleted)");
            sb.AppendLine("{");
            sb.AppendLine("    Type entityType = auditable.Entity.GetType().BaseType;");
            sb.AppendLine("    audits.Add(this.AuditEntity(auditable, auditTypes[entityType], updateDateTime.Value, user));");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("// Perform the updates.");
            sb.AppendLine("try");
            sb.AppendLine("{");
            sb.AppendLine("    var changes = ChangeTracker.Entries<IAuditable>().Where(e => e.State == EntityState.Added).ToList();");
            sb.AppendLine("    base.SaveChanges();");
            sb.AppendLine("    var completedChanges = new List<DbEntityEntry<IAuditable>>();");
            sb.AppendLine("");
            sb.AppendLine("foreach (var audit in audits)");
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("foreach (var change in changes)");
            sb.AppendLine("{");
            sb.AppendLine("    if (audit.StampID == 0 && audit.GetType() == auditTypes[change.Entity.GetType()].AuditEntityType");
            sb.AppendLine("            && completedChanges.IndexOf(change) == -1)");
            sb.AppendLine("    {");
            sb.AppendLine("        audit.StampID = change.Entity.ID;");
            sb.AppendLine("        completedChanges.Add(change);");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("return base.SaveChanges();");
            sb.AppendLine("");
            sb.AppendLine("}");
            sb.AppendLine("catch (Exception ex)");
            sb.AppendLine("{");
            sb.AppendLine("    // Updated failed so remove the audit entities.");
            sb.AppendLine("    foreach (var item in audits)");
            sb.AppendLine("    {");
            sb.AppendLine("        this.Set(item.GetType()).Remove(item);");
            sb.AppendLine("    }");
            sb.AppendLine("");
            sb.AppendLine("throw;");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("else");
            sb.AppendLine("{");
            sb.AppendLine("    return base.SaveChanges();");
            sb.AppendLine("}");
            sb.AppendLine(" }");
            sb.AppendLine("");
            sb.AppendLine(" private IAudit AuditEntity(DbEntityEntry entityEntry, AuditTypeInfo auditTypeInfo, DateTime auditDateTime, string user)");
            sb.AppendLine(" {");
            sb.AppendLine("// Create audit entity.");
            sb.AppendLine("DbSet set = this.Set(auditTypeInfo.AuditEntityType);");
            sb.AppendLine("IAudit auditEntity = set.Create() as IAudit;");
            sb.AppendLine("set.Add(auditEntity);");
            sb.AppendLine("");
            sb.AppendLine("// Copy the properties.");
            sb.AppendLine("DbEntityEntry auditEntityEntry = this.Entry(auditEntity);");
            sb.AppendLine("foreach (string propertyName in auditTypeInfo.AuditProperties)");
            sb.AppendLine("{");
            sb.AppendLine("if (entityEntry.State == EntityState.Deleted)");
            sb.AppendLine("{");
            sb.AppendLine("    if (propertyName.ToLower() != \"id\")");
            sb.AppendLine("    {");
            sb.AppendLine("        auditEntityEntry.Property(propertyName).CurrentValue = entityEntry.OriginalValues[propertyName];");
            sb.AppendLine("    }");
            sb.AppendLine("    else");
            sb.AppendLine("    {");
            sb.AppendLine("        auditEntityEntry.Property(AuditStampIDColumnName).CurrentValue = entityEntry.OriginalValues[propertyName];");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("else");
            sb.AppendLine("{");
            sb.AppendLine("    if (propertyName.ToLower() != \"id\")");
            sb.AppendLine("    {");
            sb.AppendLine("        auditEntityEntry.Property(propertyName).CurrentValue = entityEntry.Property(propertyName).CurrentValue;");
            sb.AppendLine("    }");
            sb.AppendLine("    else");
            sb.AppendLine("    {");
            sb.AppendLine("        auditEntityEntry.Property(AuditStampIDColumnName).CurrentValue = entityEntry.Property(propertyName).CurrentValue;");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("// Set the audit columns.");
            sb.AppendLine("auditEntityEntry.Property(AuditStampDateColumnName).CurrentValue = auditDateTime;");
            sb.AppendLine("auditEntityEntry.Property(AuditStampUserColumnName).CurrentValue = user;");
            sb.AppendLine("auditEntityEntry.Property(AuditStampIDColumnName).CurrentValue = entityEntry.Property(\"ID\").CurrentValue;");
            sb.AppendLine("switch (entityEntry.State)");
            sb.AppendLine("{");
            sb.AppendLine("case EntityState.Modified:");
            sb.AppendLine("    auditEntityEntry.Property(AuditActionColumnName).CurrentValue = \"U\";");
            sb.AppendLine("    break;");
            sb.AppendLine("case EntityState.Added:");
            sb.AppendLine("    auditEntityEntry.Property(AuditActionColumnName).CurrentValue = \"I\";");
            sb.AppendLine("    break;");
            sb.AppendLine("case EntityState.Deleted:");
            sb.AppendLine("    auditEntityEntry.Property(AuditActionColumnName).CurrentValue = \"D\";");
            sb.AppendLine("    break;");
            sb.AppendLine("default:");
            sb.AppendLine("    break;");
            sb.AppendLine("}");
            sb.AppendLine("");
            sb.AppendLine("     return auditEntity;");
            sb.AppendLine(" }");
            sb.AppendLine("}");
        }
    }
}
