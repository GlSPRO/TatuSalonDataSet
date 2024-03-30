using Praktos1PRAKTIKA.tatuSalonPRAKTIKADataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Praktos1PRAKTIKA
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {            
        clientsTableAdapter Clients = new clientsTableAdapter();
        public Client()
        {
            InitializeComponent();
            ClientsDataGrid.ItemsSource = Clients.GetData();
        }

        private void ClientsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ADDstring_Click(object sender, RoutedEventArgs e)
        {
            Clients.InsertQuery((TB_Familiya.Text), (TB_name.Text), (TB_Otchestvo.Text),
                        Convert.ToString(TB_age.Text), Convert.ToInt32(TB_phone_number.Text));

            ClientsDataGrid.ItemsSource = Clients.GetData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (ClientsDataGrid.SelectedItem as DataRowView).Row[0];
            Clients.UpdateQuery((TB_Familiya.Text), (TB_name.Text), (TB_Otchestvo.Text),
                        Convert.ToString(TB_age.Text), Convert.ToInt32(TB_phone_number.Text), Convert.ToInt32(id));

            ClientsDataGrid.ItemsSource = Clients.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (ClientsDataGrid.SelectedItem as DataRowView).Row[0];
            Clients.DeleteQuery(Convert.ToInt32(id));
            ClientsDataGrid.ItemsSource = Clients.GetData();
        }
    }
}
