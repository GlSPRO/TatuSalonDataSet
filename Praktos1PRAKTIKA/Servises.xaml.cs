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
    /// Логика взаимодействия для Servises.xaml
    /// </summary>
    public partial class Servises : Window
    {
        services_1TableAdapter Services = new services_1TableAdapter();
        public Servises()
        {
            InitializeComponent();
            ServisesDataGrid.ItemsSource = Services.GetData();
        }

        private void ServisesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void ADDstring_Button_Click(object sender, RoutedEventArgs e)
        {
            Services.InsertQuery((TB_Otchestvo.Text), Convert.ToInt32(TB_age.Text));
            ServisesDataGrid.ItemsSource = Services.GetData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (ServisesDataGrid.SelectedItem as DataRowView).Row[0];
            Services.UpdateQuery((TB_Otchestvo.Text), Convert.ToInt32(TB_age.Text), Convert.ToInt32(id));

            ServisesDataGrid.ItemsSource = Services.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

                object id = (ServisesDataGrid.SelectedItem as DataRowView).Row[0];
                Services.DeleteQuery(Convert.ToInt32(id));
                ServisesDataGrid.ItemsSource = Services.GetData();
        }
    }
}
