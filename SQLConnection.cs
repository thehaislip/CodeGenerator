using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class SQLConnection
    {

        public SqlConnectionStringBuilder connectionStringBuilder { get; set; }
        public SQLConnection()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
        }

        public string BuildConnectionString(string server, string database, string username, string password, bool isWindowsAuth)
        {
            connectionStringBuilder.DataSource = server;
            connectionStringBuilder.InitialCatalog = database;

            if (isWindowsAuth)
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionStringBuilder.UserID = username;
                connectionStringBuilder.Password = password;
            }
            return connectionStringBuilder.ConnectionString;
        }
        public bool TestConnection(string server, string database, string username, string password, bool isWindowsAuth)
        {
            using (var connection = new SqlConnection(BuildConnectionString(server, database, username, password, isWindowsAuth)))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open) // if connection.Open was successful
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    var e = ex;
                    return false;
                }
            }
        }

        public SqlConnection GetConnection(string server, string database, string username, string password, bool isWindowsAuth)
        {
            return new SqlConnection(BuildConnectionString(server, database, username, password, isWindowsAuth));
        }

    }

}

