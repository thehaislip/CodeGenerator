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
using System.Windows.Shapes;


namespace CodeGenerator
{
    /// <summary>
    /// Interaction logic for ConnectionString.xaml
    /// </summary>
    public partial class ConnectionString : Window
    {

        public SqlConnection Connection { get; set; }
        public ConnectionString()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (spUsernamePassword != null)
            {
                ComboBoxItem selection = (ComboBoxItem)e.AddedItems[0];
                if (selection.Name == "password")
                {
                    spUsernamePassword.Visibility = Visibility.Visible;
                }
                else
                {
                    spUsernamePassword.Visibility = Visibility.Hidden;
                }
            }

        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            var iswindowsAuth = ((ComboBoxItem)comboBox.SelectedValue).Name == "windows";
            if (new SQLConnection().TestConnection(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text, iswindowsAuth ))
            {
                System.Windows.MessageBox.Show("Connection Succesful");
            }
            else {
                System.Windows.MessageBox.Show("Connection Failed");
            }
        }



        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var iswindowsAuth = ((ComboBoxItem)comboBox.SelectedValue).Name == "windows";
            if (new SQLConnection().TestConnection(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text, iswindowsAuth))
            {
                Connection = new SQLConnection().GetConnection(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text, iswindowsAuth);
                new UserInfoRepository().saveConnection(txtDatabase.Text, Connection.ConnectionString, "");
                this.Close();
            }
            else {
                System.Windows.MessageBox.Show("Connection Failed");
            }
          
        }
            
    }
}
