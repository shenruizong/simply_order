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
using System.Data;

namespace server
{
    /// <summary>
    /// DishWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DishWindow : Window
    {
        public DishWindow()
        {
            InitializeComponent();
        }
        private DataTable DishDataTable;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataBase.DishModel Dish = new DataBase.DishModel();
            DishDataTable = Dish.SelectAll();
            DishList.ItemsSource = DishDataTable.DefaultView;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// 在此处添加事件处理程序实现。
            Button but = (Button)sender;
            DishInfoWindow dish_info = new DishInfoWindow();
            dish_info.DataContext = but.DataContext;
            dish_info.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataRow Row = DishDataTable.NewRow();
            AddDishWindow AddDish = new AddDishWindow();
            AddDish.DataContext = Row;
            AddDish.Show();
            
        }

    }
}
