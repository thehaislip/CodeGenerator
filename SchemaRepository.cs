using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class SchemaRepository
    {
        public IEnumerable<DatabaseTable> ListTables(SqlConnection conn)
        {
            var lst = new List<DatabaseTable>();
            var cmd = BuildCommand(conn, "select t.name from sys.tables t where t.type = 'u' and t.name not like 'sysdiagrams%'");
            using (conn)
            {
                conn.Open();
                using (var rdr  = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lst.Add(new DatabaseTable() {Name = rdr["name"].ToString() });
                    }
                }
               
            }
            foreach (var item in lst)
            {
                var columns = ListColumns(conn, item.Name);
                item.Columns = columns;
                item.ParentNavigationProperties = ListRelationships(conn, item.Name, true);
                item.ChildNavigationProperties = ListRelationships(conn, item.Name, false);
            }
            return lst;
        }

        public IEnumerable<DatabaseColumn> ListColumns(SqlConnection conn, string tablename)
        {
            var lst = new List<DatabaseColumn>();
            var cmdText = "select COLUMN_NAME, IS_NULLABLE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, Numeric_Scale from INFORMATION_SCHEMA.COLUMNS";
            var cmd = BuildCommand(conn, cmdText);
            using (conn)
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lst.Add(new DatabaseColumn() {
                            Name = rdr["Name"].ToString(),
                            DataType = rdr["Data_Type"].ToString(),
                            IsNull = rdr["IS_NULLABLE"].ToString() == "YES",
                            Length = rdr["CHARACTER_MAXIMUM_LENGTH"].ToString(),
                            Precision = rdr["Numeric_Precision"].ToString(),
                            Scale = rdr["NumericScale"].ToString()
                        });
                    }
                }
            }
            return lst;
        }

        public IEnumerable<DatabaseRelationship> ListRelationships(SqlConnection conn, string tableName, bool checkParant)
        {
            var lst = new List<DatabaseRelationship>();
            var sb = new StringBuilder();
            var cmdText = "";
            sb.Append("SELECT");
            sb.Append(" Child_Table = FK.TABLE_NAME,");
            sb.Append(" FK_Column = CU.COLUMN_NAME,");
            sb.Append(" Parent_Table = PK.TABLE_NAME,");
            sb.Append(" PK_Column = PT.COLUMN_NAME, ");
            sb.Append(" Constraint_Name = C.CONSTRAINT_NAME");
            sb.Append(" FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS C");
            sb.Append(" INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS FK ON C.CONSTRAINT_NAME = FK.CONSTRAINT_NAME");
            sb.Append(" INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS PK ON C.UNIQUE_CONSTRAINT_NAME = PK.CONSTRAINT_NAME");
            sb.Append(" INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE CU ON C.CONSTRAINT_NAME = CU.CONSTRAINT_NAME");
            sb.Append(" INNER JOIN (");
            sb.Append(" SELECT i1.TABLE_NAME, i2.COLUMN_NAME");
            sb.Append(" FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1");
            sb.Append(" INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME");
            sb.Append(" WHERE i1.CONSTRAINT_TYPE = 'PRIMARY KEY'");
            sb.Append(" PT ON PT.TABLE_NAME = PK.TABLE_NAME");
            if (checkParant)
            {
                sb.Append($" where pk.table_name = '{tableName}'");
            }
            else
            {
                sb.Append($" where fk.table_name = '{tableName}'");
            }
            
            cmdText = sb.ToString();
            var cmd = BuildCommand(conn, cmdText);
            using (conn)
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lst.Add(new DatabaseRelationship() {
                            ParentTable = rdr["Parent_Table"].ToString(),
                            PKColumn = rdr["PK_Column"].ToString(),
                            ChildTable = rdr["Child_Table"].ToString(),
                            FKColumn = rdr["FK_Column"].ToString()
                        });
                    }
                }
            }
            return lst;
        }

        private SqlCommand BuildCommand(SqlConnection conn, string commandText)
        {

            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = commandText;
            return cmd;
        }
    }
}
