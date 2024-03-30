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
using Praktos1PRAKTIKA.tatuSalonPRAKTIKADataSetTableAdapters;

namespace Praktos1PRAKTIKA
{
    /// <summary>
    /// Логика взаимодействия для Masters.xaml
    /// </summary>
    public partial class Masters : Window
    {
        mastersTableAdapter Master = new mastersTableAdapter();
        public Masters()
        {
            InitializeComponent();
            MastersDataGrid.ItemsSource = Master.GetData();
        }

        private void MastersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ADDstring_Click(object sender, RoutedEventArgs e)
        {
            Master.InsertQuery((TB_name.Text), Convert.ToInt32(TB_age.Text));
            MastersDataGrid.ItemsSource = Master.GetData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (MastersDataGrid.SelectedItem as DataRowView).Row[0];
            Master.UpdateQuery((TB_name.Text), Convert.ToInt32(TB_age.Text), Convert.ToInt32(id));

            MastersDataGrid.ItemsSource = Master.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (MastersDataGrid.SelectedItem as DataRowView).Row[0];
            Master.DeleteQuery(Convert.ToInt32(id));
            MastersDataGrid.ItemsSource = Master.GetData();
        }
    }
}
