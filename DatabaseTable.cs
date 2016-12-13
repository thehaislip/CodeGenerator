using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class DatabaseTable
    {
       
        public IEnumerable<DatabaseColumn> Columns { get; internal set; }
        public string Name { get; internal set; }
        public IEnumerable<DatabaseRelationship> NavigationProperties { get; internal set; }
       
    }
}
