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

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int count = 4;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Main.Text == "4")
            {
                if4 a = new if4();
                a.Show();
                this.Close();
                count = 4;
            }
            else if(Main.Text == "3")
            {
                if3 a = new if3();
                a.Show();
                this.Close();
                count = 3;
            }
            else if (Main.Text == "2")
            {
                if2 a = new if2();
                a.Show();
                this.Close();
                count = 2;
            }
            else if (Main.Text == "1")
            {
                if1 a = new if1();
                a.Show();
                this.Close();
                count = 1;
            }
        }
    }
}
