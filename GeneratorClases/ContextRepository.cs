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
        private SqlConnection conn;
        private SchemaRepository schema;

        public ContextRepository():this(new SqlConnection())
        {
            schema = new SchemaRepository();
        }

        public ContextRepository(SqlConnection conn)
        {
            this.conn = conn;
            schema = new SchemaRepository();
        }

        public string GetContextString() {
           var tables =    schema.ListTables(conn);
            return "";
        }
    }
}
