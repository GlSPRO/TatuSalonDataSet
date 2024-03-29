using Praktos1PRAKTIKA.tatuSalonPRAKTIKADataSetTableAdapters;
using System;
using System.Collections.Generic;
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
    }
}
