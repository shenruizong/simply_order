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
    /// ServerWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ServerWindow : Window
    {
        public ServerWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new TableShowWindow().Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            new DishWindow().Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            new OrdersWindow().Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            new ClosingWindow().Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            new StatisticsWindow().Show();
        }
    }
}
