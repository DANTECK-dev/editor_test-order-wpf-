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

namespace Order
{
    /// <summary>
    /// Логика взаимодействия для Creator_tests.xaml
    /// </summary>
    public partial class Creator_tests : Window
    {

        public Creator_tests()
        {
            InitializeComponent();
        }
        private void Done_Click(object sender, RoutedEventArgs e)
        {

            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
        private void Edit_Num_Of_Answear_Left_Click(object sender, RoutedEventArgs e)
        {
            string nums = Nums.Content.ToString();
            int num = int.Parse(nums);
            if (num == 0) num = 1;
            num--;
            if (num < 1 || num > 8) return;
            Nums.Content = num.ToString();
        }
        private void Edit_Num_Of_Answear_Right_Click(object sender, RoutedEventArgs e)
        {
            string nums = Nums.Content.ToString();
            int num = int.Parse(nums);
            if (num == 0) num = 1;
            num++;
            if (num < 1 || num > 8) return;
            Nums.Content = num.ToString();
        }
        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            
        }
        private void Generate_Click(object sender, RoutedEventArgs e)
        {

        }

        #region Комбо_Боксы
        private void CB_Discipline(object sender, RoutedEventArgs e)
        {

            /* String[] strings = ComboBox_Discipline.Text.Split('\u002C');
             //ComboBox_Discipline.GotFocus
             String[] res = new String[strings.Length];
             int counter = 0;
             for(int i = 0; i < strings.Length; i++)
             {
                 if (ComboBox_Discipline.FindResource(strings[i]) != null)
                 {
                     res[counter++] = strings[i];
                 }
                 //MessageBox.Show(strings[i]);
             }
             ComboBox_Discipline.ItemsSource = res;*/
        }
        private void CB_Theme(object sender, SelectionChangedEventArgs e)
        {

        }
        private void CB_Question(object sender, SelectionChangedEventArgs e)
        {

        }
        private void CB_Num_Of_Answear(object sender, SelectionChangedEventArgs e)
        {

        }
        private void CB_Key_Answear(object sender, SelectionChangedEventArgs e)
        {

        }
        private void CB_True_Key_Answear(object sender, SelectionChangedEventArgs e)
        {

        }
        private void CB_Answear(object sender, SelectionChangedEventArgs e)
        {

        }
        #endregion
    }
}
