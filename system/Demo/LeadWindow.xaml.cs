using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// LeadWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LeadWindow : Window
    {
        public LeadWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            new OpenWindow().Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            new TurnWindow().Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            new ServerWindow().Show();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            new CheckOutWindow().Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            new DishWindow().Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            new OrdersWindow().Show();
        }
    }
}
