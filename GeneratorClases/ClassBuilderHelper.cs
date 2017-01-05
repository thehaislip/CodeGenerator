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
                .AppendLine(" using System.ComponentModel.DataAnnotations;")
                .AppendLine("using System.ComponentModel.DataAnnotations.Schema;")
                .AppendLine("using System.Linq;");

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
            if (column.PrimaryKey)
            {
                sb.AppendLine("[Key]");
                sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
            }
            sb.AppendLine($"public {ConvertToCSharpType(column.DataType)} {column.Name}" + " {get; set;}");
            return sb;
        }

        private static string ConvertToCSharpType(string dataType)
        {
            string strReturn;
            switch (dataType.ToLower())
            {
                case "Integer":
                    strReturn = "int";
                    break;
                case "Decimal":
                    strReturn = "decimal";
                    break;
                case "Double":
                    strReturn = "double";
                    break;
                case "Boolean":
                    strReturn = "bool";
                    break;
                case "Date":
                    strReturn = "DateTime";
                    break;
                case "String":
                    strReturn = "string";
                    break;
                default:
                    strReturn = dataType;
                    break;
            }
            return strReturn;
        }
    }
}
