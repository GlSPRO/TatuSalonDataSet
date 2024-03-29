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
    }
}
