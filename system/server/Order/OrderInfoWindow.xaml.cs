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
using System.Globalization;

namespace server.Order
{
    /// <summary>
    /// OrderInfoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OrderInfoWindow : Window
    {
        public DataRowView RowView;
        public OrderInfoWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataRowView RowView = (DataRowView)this.DataContext;
            Int64 Order_num = Int64.Parse(RowView["order_num"].ToString());
            DataBase.OrderInfoModel info = new DataBase.OrderInfoModel();
            DataTable dt = info.GetByOrderid(Order_num);
            DishList.ItemsSource = dt.DefaultView;
        }

    }
}
