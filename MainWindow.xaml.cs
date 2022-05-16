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

namespace _3._6WrapPanel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel1 wrapPanel1 = new WrapPanel1();
            wrapPanel1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WrapPanel2 wrapPanel2 = new WrapPanel2();
            wrapPanel2.Show();
        }
    }
}
