using Praktos1PRAKTIKA.tatuSalonPRAKTIKADataSetTableAdapters;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Praktos1PRAKTIKA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        appointmentsTableAdapter Appointments = new appointmentsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ClientDG.ItemsSource = Appointments.GetData();

        }

        private void AppointmentsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Click_Servises_Click(object sender, RoutedEventArgs e)
        {
            Servises masters = new Servises();
            masters.Show();
        }

        private void Click_Master_Click(object sender, RoutedEventArgs e)
        {
            Masters masters = new Masters();
            masters.Show();
        }

        private void Click_Clients_Click(object sender, RoutedEventArgs e)
        {
            Client masters = new Client();
            masters.Show();
        }

        private void ADDstring_Button_Click(object sender, RoutedEventArgs e)
        {
            Appointments.InsertQuery(Convert.ToInt32(TB_ClientID.Text), Convert.ToInt32(TB_ServiceID.Text),
                                    Convert.ToInt32(TB_MastersID.Text), (TB_Familiya.Text), (TB_name.Text), (TB_Otchestvo.Text),
                                    Convert.ToInt32(TB_age.Text), Convert.ToInt32(TB_phone_number.Text));

            ClientDG.ItemsSource = Appointments.GetData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (ClientDG.SelectedItem as DataRowView).Row[0];
            Appointments.UpdateQuery(Convert.ToInt32(TB_ClientID.Text), Convert.ToInt32(TB_ServiceID.Text),
                                    Convert.ToInt32(TB_MastersID.Text), (TB_Familiya.Text), (TB_name.Text), (TB_Otchestvo.Text),
                                    Convert.ToInt32(TB_age.Text), Convert.ToInt32(TB_phone_number.Text), Convert.ToInt32(id));

            ClientDG.ItemsSource = Appointments.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (ClientDG.SelectedItem as DataRowView).Row[0];
            Appointments.DeleteQuery(Convert.ToInt32(id));
            ClientDG.ItemsSource = Appointments.GetData();
        }
    }
}
