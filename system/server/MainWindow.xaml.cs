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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace server
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Tables.TablesWindow TablesWindow = new Tables.TablesWindow();
        private Dish.DishWindow dishWindow = new Dish.DishWindow();
        private Order.OrdersWindow OrdersWindow = new Order.OrdersWindow();
        private void DishButton_Click(object sender, RoutedEventArgs e)
        {
            if (dishWindow.IsVisible)
            {
                dishWindow.Activate();
            }
            else
            {
                dishWindow = new Dish.DishWindow();
                dishWindow.Show();
            }

        }

        private void TablesButton_Click(object sender, RoutedEventArgs e)
        {
            if (TablesWindow.IsVisible)
            {
                TablesWindow.Activate();
            }
            else
            {
                TablesWindow = new Tables.TablesWindow();
                TablesWindow.Show();
            }
        }

        private void OrderButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // 在此处添加事件处理程序实现。
            if (OrdersWindow.IsVisible)
            {
                OrdersWindow.Activate();
            }
            else
            {
                OrdersWindow = new Order.OrdersWindow();
                OrdersWindow.Show();
            }
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            Statistics.StatisticsWindow windows = new Statistics.StatisticsWindow();
            windows.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
