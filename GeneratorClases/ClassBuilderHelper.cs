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
                .AppendLine("using System.Collections.Generic;");

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

        public static StringBuilder GetConstructor(this StringBuilder sb, DatabaseTable table)
        {
            sb.AppendLine($"public {table.Name}()");
            sb.AppendLine("{");
            foreach (var item in table.NavigationProperties.Where(e => e.RelationshipType == "Many"))
            {
                sb.AppendLine($"this.{item.RelatedTable}s = new HashSet<{item.RelatedTable}>();");
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
        public static StringBuilder GetProperty(this StringBuilder sb, DatabaseColumn column)
        {
            sb.GetDecorators(column);
            sb.AppendLine($"public {ConvertToCSharpType(column)} {column.Name}" + " {get; set;}");
            return sb;
        }

        private static string ConvertToCSharpType(DatabaseColumn column)
        {
            string strReturn;
            switch (column.DataType.ToLower())
            {
                case "int":
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
                    strReturn = "DateTime";
                    break;
                case "varchar":
                case "nvarchar":
                    strReturn = "string";
                    break;
                case "timestamp":
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
        private static StringBuilder GetDecorators(this StringBuilder sb, DatabaseColumn column)
        {
            if (column.PrimaryKey)
            {
                sb.AppendLine("[Key]");
                sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
            }
            if (!column.IsNull)
            {
                sb.AppendLine("[Required]");
            }
            switch (column.DataType.ToLower())
            {
                case "money":
                case "date":
                case "datetime2":
                    sb.AppendLine($"[Column(TypeName = \"{column.DataType.ToLower()}\")]");
                    break;
                case "timestamp":
                    sb.AppendLine($"[Column(TypeName = \"{column.DataType.ToLower()}\")]");
                    sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Computed)]");
                    sb.AppendLine("[MaxLength(8)]");
                    break;
                case "varchar":
                case "nvarchar":
                    sb.AppendLine($"[StringLength({column.Length})]");
                    break;
                default:
                    break;
            }
            return sb;
        }
    }
}
