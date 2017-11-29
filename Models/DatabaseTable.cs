using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
   public class DatabaseTable
    {
        public DatabaseTable()
        {
            this.Columns = new List<DatabaseColumn>();
            this.NavigationProperties = new List<DatabaseRelationship>();
        }
        public List<DatabaseColumn> Columns { get; internal set; }
        public string Name { get; internal set; }
        public List<DatabaseRelationship> NavigationProperties { get; internal set; }
       
    }
}
