using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.GeneratorClases
{
    public static class ClassBuilderHelper
    {

        public static StringBuilder GetUsings(this StringBuilder sb)
        {
            return sb.AppendLine("using System;")
                .AppendLine("using System.Data.Entity;")
                .AppendLine("using System.ComponentModel.DataAnnotations;")
                .AppendLine("using System.ComponentModel.DataAnnotations.Schema;")
                .AppendLine("using System.Linq;")
                .AppendLine("using System.Collections.Generic;")
                .AppendLine("using System.Collections.ObjectModel;")
                .AppendLine("using System.Data.Entity.Infrastructure;")
                .AppendLine("using System.Security.Principal;");

        }
        public static StringBuilder GetNamespace(this StringBuilder sb, string ns)
        {
            return sb.AppendLine($"namespace {ns}")
                .AppendLine("{ ");
        }
        public static StringBuilder GetClass(this StringBuilder sb, string className, string inherits)
        {
            sb.AppendLine($"public partial class {className}");
            if (inherits != "")
            {
                sb.Append($":{inherits}");
            }
            sb.AppendLine("{ ");
            return sb;
        }

        public static StringBuilder GetConstructor(this StringBuilder sb, DatabaseTable table, bool isAudit = false)
        {

            sb.AppendLine($"public {table.Name}{(isAudit ? "Audit" : "")}()");
            sb.AppendLine("{");
            if (!isAudit)
            {
                var tablesUsed = new List<string>();
                foreach (var item in table.NavigationProperties.Where(e => e.RelationshipType == "Many"))
                {
                    var relatedTable = item.RelatedTable;

                    if (string.Equals(relatedTable, table.Name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        relatedTable = $"Super{relatedTable}";
                    }
                    if (tablesUsed.Any(e => e == relatedTable))
                    {
                        relatedTable = $"{relatedTable}{tablesUsed.Count(e => e == relatedTable)}";
                    }
                    tablesUsed.Add(relatedTable);
                    sb.AppendLine($"this.{relatedTable}s = new HashSet<{item.RelatedTable}>();");
                }
            }
            sb.AppendLine("}");
            return sb;
        }
        public static StringBuilder GetFunctionEnd(this StringBuilder sb)
        {
            return sb.AppendLine("}");
        }
        public static StringBuilder GetClassEnd(this StringBuilder sb)
        {
            return sb.AppendLine("}");
        }
        public static StringBuilder GetNamespaceEnd(this StringBuilder sb)
        {
            return sb.AppendLine("}");
        }
        public static StringBuilder GetProperty(this StringBuilder sb, DatabaseColumn column, bool isEntity = true)
        {
            sb.GetDecorators(column,isEntity);
            if (column.Name.ToLower() == "id")
            {
                sb.AppendLine($"public {ConvertToCSharpType(column)} {column.Name.ToUpper()}" + " {get; set;}");
            }
            else
            {
                sb.AppendLine($"public {ConvertToCSharpType(column)} {Humanizer.StringDehumanizeExtensions.Dehumanize(column.Name)}" + " {get; set;}");
            }
            
            return sb;
        }

        private static string ConvertToCSharpType(DatabaseColumn column)
        {
            string strReturn;
            switch (column.DataType.ToLower())
            {
                case "int":
                case "tinyint":
                    strReturn = "int";
                    break;
                case "decimal":
                case "money":
                    strReturn = "decimal";
                    break;
                case "float":
                    strReturn = "double";
                    break;
                case "bit":
                    strReturn = "bool";
                    break;
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                    strReturn = "DateTime";
                    break;
                case "varchar":
                case "nvarchar":
                case "char":
                case "nchar":
                    strReturn = "string";
                    break;
                case "timestamp":
                case "image":
                case "varbinary":
                case "binary":
                    strReturn = "byte[]";
                    break;
                case "uniqueidentifier":
                    strReturn = "Guid";
                    break;
                default:
                    strReturn = column.DataType;
                    break;
            }
            if (column.IsNull)
            {
                if (strReturn != "string" && strReturn != "byte[]")
                {
                    strReturn += "?";
                }
            }
            return strReturn;
        }
        private static StringBuilder GetDecorators(this StringBuilder sb, DatabaseColumn column, bool isEntity = true)
        {
            if (column.PrimaryKey && isEntity)
            {
                sb.AppendLine("[Key]");
                sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
            }
            if (!column.IsNull)
            {
                if (column.DataType.ToLower() != "timestamp")
                {
                    sb.AppendLine("[Required]");
                }
            }
            switch (column.DataType.ToLower())
            {
                case "money":
                case "date":
                case "datetime2":
                    if (isEntity)
                    {
                        sb.AppendLine($"[Column(name:\"{column.Name}\",TypeName = \"{column.DataType.ToLower()}\")]");
                    }
                    break;
                case "timestamp":
                    if (isEntity)
                    {
                        sb.AppendLine($"[Column(name:\"{column.Name}\",TypeName = \"{column.DataType.ToLower()}\")]");
                        sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Computed)]");
                        sb.AppendLine("[MaxLength(8)]");
                    }
                    break;
                case "varchar":
                case "nvarchar":
                case "char":
                case "nchar":
                    if (isEntity)
                    {
                        sb.AppendLine($"[Column(name:\"{column.Name}\")]");
                    }
                    if (column.Length != "-1")
                    {
                        sb.AppendLine($"[StringLength({column.Length})]");
                    }
                    break;
                default:
                    if (isEntity)
                    {
                        sb.AppendLine($"[Column(name:\"{column.Name}\")]");
                    }
                    break;
            }
           
            return sb;
        }
    }
}
