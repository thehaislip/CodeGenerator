using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class DatabaseColumn
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string Length { get; set; }
        public bool IsNull { get; set; }
        public string Precision { get;  set; }
        public string Scale { get;  set; }
        public string ExtendedPropName { get;  set; }
        public string ExtendedProp { get;  set; }
        public bool PrimaryKey { get; internal set; }
    }
}
