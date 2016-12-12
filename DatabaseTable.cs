using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class DatabaseTable
    {
        public IEnumerable<DatabaseRelationship> ChildNavigationProperties { get; internal set; }
        public IEnumerable<DatabaseColumn> Columns { get; internal set; }
        public string Name { get; internal set; }
        public IEnumerable<DatabaseRelationship> ParentNavigationProperties { get; internal set; }
    }
}
