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

            conn.Open();
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    lst.Add(new DatabaseTable() { Name = rdr["name"].ToString() });
                }
            }
            foreach (var item in lst)
            {
                var columns = ListColumns(conn, item.Name);
                item.Columns = columns;
                item.NavigationProperties = ListRelationships(conn, item.Name);

            }
            return lst;
        }

        public IEnumerable<DatabaseColumn> ListColumns(SqlConnection conn, string tablename)
        {
            var sb = new StringBuilder();
            var lst = new List<DatabaseColumn>();
            var cmdText = "";
            sb.Append("select c.COLUMN_NAME, IS_NULLABLE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, Numeric_Scale , ep.[Extended_Property_Name], ep.[Extended_Property], iif(i2.column_name is not null,1,0) [PrimaryKey]")
                .Append(" from INFORMATION_SCHEMA.COLUMNS c")
                .Append(" left JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 ON c.COLUMN_NAME = i2.COLUMN_NAME and c.TABLE_NAME = i2.TABLE_NAME")
                .Append(" left join INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 on i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME and i1.CONSTRAINT_TYPE = 'PRIMARY KEY'")
                .Append(" left JOIN (SELECT major_id, minor_id, t.name AS [Table_Name], c.name AS[Column_Name], value AS[Extended_Property],ep.name[Extended_Property_Name]")
                .Append(" FROM sys.extended_properties AS ep")
                .Append(" INNER JOIN sys.tables AS t ON ep.major_id = t.object_id")
                .Append(" INNER JOIN sys.columns AS c ON ep.major_id = c.object_id AND ep.minor_id = c.column_id")
                .Append(" WHERE class = 1)")
                .Append(" ep on ep.[Column_Name] = c.COLUMN_NAME")
                .Append($" where c.TABLE_NAME = @tableName");
            cmdText = sb.ToString();
            
            var cmd = BuildCommand(conn, cmdText);
            cmd.Parameters.AddWithValue("@tableName", tablename);
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    lst.Add(new DatabaseColumn()
                    {
                        Name = rdr["COLUMN_NAME"].ToString(),
                        DataType = rdr["Data_Type"].ToString(),
                        IsNull = rdr["IS_NULLABLE"].ToString() == "YES",
                        Length = rdr["CHARACTER_MAXIMUM_LENGTH"].ToString(),
                        Precision = rdr["Numeric_Precision"].ToString(),
                        Scale = rdr["Numeric_Scale"].ToString(),
                        ExtendedPropName = rdr["Extended_Property_Name"].ToString(),
                        ExtendedProp = rdr["Extended_Property"].ToString(),
                        PrimaryKey = rdr["PrimaryKey"].ToString() == "1"
                    });
                }
            }

            return lst;
        }

        public IEnumerable<DatabaseRelationship> ListRelationships(SqlConnection conn, string tableName)
        {
            var lst = new List<DatabaseRelationship>();
            var sb = new StringBuilder();
            var cmdText = "";
            sb.Append("SELECT t.name AS[TableName]")
                 .Append(" , c.name AS[ColumnName]")
                 .Append(" , CASE WHEN COALESCE(tr.name, tr2.name) IS NULL THEN 'No'")
                 .Append(" ELSE 'Yes' END AS IsColumnInRelation")
                 .Append(" ,COALESCE(tr.name, tr2.name) AS[RelatedTable]")
                 .Append(" ,COALESCE(cr.name, cr2.name) AS[RelatedColumn]")
                 .Append(" ,CASE WHEN COALESCE(tr.name, tr2.name) IS NOT NULL THEN")
                 .Append(" CASE WHEN i.object_id IS NOT NULL THEN 'One'")
                 .Append(" ELSE 'Many' END")
                 .Append(" END AS RelationKind")
                 .Append(" FROM sys.columns c")
                 .Append(" INNER JOIN sys.tables t ON t.object_id = c.object_id")
                 .Append(" LEFT JOIN  sys.index_columns ic  ON ic.object_id = c.object_id  AND ic.column_id = c.column_id")
                 .Append(" LEFT JOIN sys.indexes i  ON ic.object_id = i.object_id   AND i.is_primary_key = 1")
                 .Append(" LEFT JOIN sys.foreign_key_columns AS fc ON c.object_id = fc.parent_object_id AND c.column_id = fc.parent_column_id")
                 .Append(" LEFT JOIN sys.columns cr ON cr.object_id = fc.referenced_object_id AND cr.column_id = fc.referenced_column_id")
                 .Append(" LEFT JOIN sys.tables tr ON cr.object_id = tr.object_id")
                 .Append(" LEFT JOIN sys.foreign_key_columns AS fc2 ON c.object_id = fc2.referenced_object_id AND c.column_id = fc2.referenced_column_id")
                 .Append(" LEFT JOIN sys.columns cr2 ON cr2.object_id = fc2.parent_object_id AND cr2.column_id = fc2.parent_column_id")
                 .Append(" LEFT JOIN sys.tables tr2 ON cr2.object_id = tr2.object_id")
                 .Append(" where COALESCE(tr.name, tr2.name) is not null")
                 .Append($" and COALESCE(tr.name, tr2.name) = @tableName");

            cmdText = sb.ToString();
            var cmd = BuildCommand(conn, cmdText);
            cmd.Parameters.AddWithValue("@tableName", tableName);
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {

                    var rel = new DatabaseRelationship();
                    rel.Table = rdr["TableName"].ToString();
                    rel.Column = rdr["ColumnName"].ToString();
                    rel.RelationshipType = rdr["RelationKind"].ToString();
                    lst.Add(rel);
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
