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
using System.Windows.Forms;//для MessageBox`а
using MessageBox = System.Windows.Forms.MessageBox;//это тоже для MessageBox`а

namespace Order
{
    /// <summary>
    /// Логика взаимодействия для Editor_tests.xaml
    /// </summary>
    enum Field_Type
    {
        Discipline = 0,
        Theme = 1,
        Question = 2,
        Num_Of_Answear = 3,
        Key_Answear = 4,
        True_Key_Answear = 5,
        Answear = 6
    }
    public partial class Editor_tests : Window
    {
        
        public Editor_tests()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {

            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
        String Err_Empty_Title = "Ошибка: Пустое поле";
        String Err_Empty = "Заполните необходимые поля\n и повторно нажмите на кнопку";

        /*private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Edit_menu win = new Edit_menu();
            win.Show();
            this.Close();
        }*/

        private bool err(string err)
        {
            if (err == "" || err == " ")
            {
                //MessageBox.Show(Err_Empty); 
                MessageBox.Show(
                    Err_Empty,
                    Err_Empty_Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

#region Кнопки_изменения
        private void Edit_Discipline_Click(object sender, RoutedEventArgs e)
        {
            String str = ComboBox_Discipline.Text.ToString();
            if (err(str)) return;

            /*if (ComboBox_Discipline.TabIndex.ToString();)
            {
                MessageBox.Show("Найдено " + str);
            }
            else
            {
                MessageBox.Show("Ненайдено " + str);
            }*/
            Edit_menu win = new Edit_menu(str, 0);
            win.Show();
            this.Close();
        }
        private void Edit_Theme_Click(object sender, RoutedEventArgs e)
        {
            String str = ComboBox_Theme.Text.ToString();
            if (err(str)) return;
            Edit_menu win = new Edit_menu(str, 1);
            win.Show();
            this.Close();
        }
        private void Edit_Question_Click(object sender, RoutedEventArgs e)
        {
            String str = ComboBox_Question.Text.ToString();
            if (err(str)) return;
            Edit_menu win = new Edit_menu(str, 2);
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
        private void Edit_True_Key_Answear_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Edit_Answear_Click(object sender, RoutedEventArgs e)
        {
            String str = ComboBox_Answear.Text.ToString();
            if (err(str)) return;
            Edit_menu win = new Edit_menu(str, 3);
            win.Show();
            this.Close();
        }
        #endregion

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
