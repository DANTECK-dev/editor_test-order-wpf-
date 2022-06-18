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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Order
{
    

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String Blue = "#7EB9DB";
            String Light_blue = "#91DDEB";
            String Green = "#C3FFDD";
            String Purple = "#BD9FDF";

        }

        private void Button_Click(object sender, RoutedEventArgs e)//Выход из приложения
        {
            this.Close();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)//Сгенерировать тест
        {
            Generator_tests win= new Generator_tests();
            win.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//Создать тест
        {
            Creator_tests win= new Creator_tests();
            win.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//Редактировать тест
        {
            Editor_tests win= new Editor_tests();
            win.Show();
            this.Close();
        }
    }
}
