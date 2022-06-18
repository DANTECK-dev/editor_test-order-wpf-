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
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace Order
{
    /// <summary>
    /// Логика взаимодействия для Generator_tests.xaml
    /// </summary>
    public partial class Generator_tests : Window
    {
        public Generator_tests()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
        private void Generate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }
    }
}
