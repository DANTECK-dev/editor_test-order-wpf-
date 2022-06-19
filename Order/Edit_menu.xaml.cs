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
    /// Логика взаимодействия для Edit_menu.xaml
    /// </summary>
    /// 
    //enum Field_Type
    //{
    //    Discipline = 0,
    //    Theme = 1,
    //    Question = 2,
    //    Num_Of_Answear = 3,
    //    Key_Answear = 4,
    //    True_Key_Answear = 5,
    //    Answear = 6
    //}

    public partial class Edit_menu : Window
    {
        String Err_Empty_Title = "Ошибка: Пустое поле";
        String Err_Empty = "Заполните необходимые поля\n и повторно нажмите на кнопку";

        String editing_text;
        private int Type;
        public Edit_menu(string editing_text, int Type)
        {
            InitializeComponent();
            this.editing_text = editing_text;
            label_Edit_Text.Content = editing_text;
            this.Type = Type;
            switch (this.Type)
            {
                case 0: label_Edit_Title.Content = "дисциплины"; break;
                case 1: label_Edit_Title.Content = "темы"; break;
                case 2: label_Edit_Title.Content = "вопроса"; break;
                case 3: label_Edit_Title.Content = "ответа"; break;

            }
            
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Editor_tests win = new Editor_tests();
            win.Show();
            this.Close();

        }
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            String str = input_str.Text.ToString();
            if(str == "" || str == " ")
            {
                MessageBox.Show(
                    Err_Empty,
                    Err_Empty_Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            MessageBox.Show("Изменено " + editing_text + "\nна " + str);

            Editor_tests win = new Editor_tests();
            win.Show();
            this.Close();
        }
    }
}
