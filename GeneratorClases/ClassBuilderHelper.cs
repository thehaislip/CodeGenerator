using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.GeneratorClases
{
    public static class  ClassBuilderHelper
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
            return sb.AppendLine("namespace CodeGenerator")
                .AppendLine("{ ");
        }
        public static StringBuilder GetClass(this StringBuilder sb, string className,string inherits)
        {
            sb.AppendLine("public partial class CodeGenerator");
            if (inherits != "")
            {
                sb.Append($":{inherits}");
            }
             sb.AppendLine("{ ");
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
    }
}
