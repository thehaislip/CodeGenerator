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

        public string buildContextClass( string databaseName)
        {
            var sb = new StringBuilder();
            sb.GetUsings()
                .GetNamespace("GeneratedContext")
                .GetClass($"{databaseName}Context", "DbContext")
                .AppendLine(" public Context()")
                .AppendLine($": base(\"name = {databaseName}Context\")")
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
                sb.AppendLine($"public virtual DbSet<{table.Name}> {table.Name} {"{ get; set; }"}");
            }
            return sb.ToString();
        }
        public string GetOnModelCreatingFunction(IEnumerable<DatabaseTable> tables)
        {
            var sb = new StringBuilder();
            sb.AppendLine("protected override void OnModelCreating(DbModelBuilder modelBuilder)")
                  .AppendLine("{").ToString();
            foreach (var table in tables.Take(10))
            {
                foreach (var colum in table.Columns.Where(e => e.DataType.ToLower() == "varchar"))
                {
                    sb.AppendLine($"modelBuilder.Entity<{table.Name}>()")
                   .AppendLine($".Property(e => e.{colum.Name})")
                   .AppendLine(".IsUnicode(false);");
                }
            }
            sb.GetFunctionEnd();
            return sb.ToString();
        }

        public string GetEntityClasses()
        {
            var sb = new StringBuilder();
            sb.GetUsings()
                .GetNamespace("GeneratedContext");
            foreach (var table in tables)
            {
                sb.GetClass($"{table.Name}","");
                sb.GetConstructor(table);
                sb.GetClassEnd();
                foreach (var column in table.Columns)
                {

                }
            }
                
            return sb.ToString();
        }
    }
}
