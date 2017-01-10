using CodeGenerator.GeneratorClases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqlConnection conn { get; set; }
        public string connString { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            loadDatabases();
        }


        private void btnConnection_Click(object sender, RoutedEventArgs e)
        {
            ConnectionString connectionWindow = new ConnectionString();
            connectionWindow.ShowDialog();
            conn = connectionWindow.Connection;
            connString = conn.ConnectionString;
            txtConnectionString.Text = connString;
            loadDatabases();
            // SqlConnection result = connectionWindow.ShowDialog();
        }

        private void cbPreviousDb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPreviousDb.SelectedValue != null)
            {
                var selection = cbPreviousDb.SelectedValue;
                connString = new UserInfoRepository().GetConnectionString(selection.ToString());
                txtConnectionString.Text = connString;
            }
        }



        private void btnDatabaseClasses_Click(object sender, RoutedEventArgs e)
        {

            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = connString;
            }
            var saveLocation = PickFolder(conn.Database + "Context.cs");
            if (saveLocation != "")
            {
                var schemaRepo = new SchemaRepository(conn);
                var repo = new ContextRepository(schemaRepo);
                var contextString = repo.GetContextString(conn.Database);
                var classes = repo.GetEntityClasses();
                contextString += classes;
                File.WriteAllText(saveLocation, contextString);
            }

        }

        private void btnViewClasses_Click(object sender, RoutedEventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = connString;
            }
            var saveLocation = PickFolder(conn.Database + "Views.cs");
            if (saveLocation != "")
            {
                var schemaRepo = new SchemaRepository(conn);
                var repo = new ViewRepository(schemaRepo);
                var viewString = repo.GetViewString(conn.Database);
                File.WriteAllText(saveLocation, viewString);
            }
        }

        private void btnAngularClasses_Click(object sender, RoutedEventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = connString;
            }
            var saveLocation = PickFolder(conn.Database + "Interfaces.ts");
            if (saveLocation != "")
            {
                var schemaRepo = new SchemaRepository(conn);
                var repo = new AngularInterfaceRepository(schemaRepo);
                var angularString = repo.GetInterfaceString(conn.Database);
                File.WriteAllText(saveLocation, angularString);
            }
        }

        private string PickFolder(string fileName)
        {
            var fld = new System.Windows.Forms.SaveFileDialog();
            fld.FileName = fileName;
            var result = fld.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                return fld.FileName;
            }
            return "";
        }

        private void loadDatabases()
        {
            cbPreviousDb.ItemsSource = new UserInfoRepository().ListDatabases();
        }
    }
}
