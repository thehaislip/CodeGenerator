using CodeGenerator.GeneratorClases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            // loadDatabases();
        }


        private void btnConnection_Click(object sender, RoutedEventArgs e)
        {
            ConnectionString connectionWindow = new ConnectionString();
            connectionWindow.ShowDialog();
            conn = connectionWindow.Connection;
            connString = conn.ConnectionString;
            txtConnectionString.Text = connString;
            //  loadDatabases();
            // SqlConnection result = connectionWindow.ShowDialog();
        }

        private void cbPreviousDb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPreviousDb.SelectedValue != null)
            {
                var selection = (int)cbPreviousDb.SelectedValue;
                connString = new UserInfoRepository().GetConnectionString(selection);
                txtConnectionString.Text = connString;
            }
        }



        private void btnDatabaseClasses_Click(object sender, RoutedEventArgs e)
        {
            //   var saveLocation = PickFolder();
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = connString;
            }
            var repo = new ContextRepository(conn);

            var w = repo.GetContextString(conn.Database);
            w = "";
        }

        private void btnViewClasses_Click(object sender, RoutedEventArgs e)
        {
            var saveLocation = PickFolder();
        }

        private void btnAngularClasses_Click(object sender, RoutedEventArgs e)
        {
            var saveLocation = PickFolder();
        }

        private string PickFolder()
        {
            var fld = new System.Windows.Forms.FolderBrowserDialog();
            var result = fld.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                return fld.SelectedPath;
            }
            return "";
        }

        private void loadDatabases()
        {
            cbPreviousDb.ItemsSource = new UserInfoRepository().ListDatabases();
            cbPreviousDb.DisplayMemberPath = "Name";
            cbPreviousDb.SelectedValuePath = "Id";
        }
    }
}
