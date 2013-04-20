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
    /// OrdersWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OrdersWindow : Window
    {
        public OrdersWindow()
        {
            InitializeComponent();
        }
		private void DateTimeNow()
		{
			string time = DateTime.Now.ToShortDateString();
            StartTime.Text = time;
            EndTime.Text = time;
		}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTimeNow();
            DataBase.OrdersModel orders = new DataBase.OrdersModel();
            DataTable dt = orders.SelectAll();
            OrderList.ItemsSource = dt.DefaultView;
        }

        private void OrderList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OrderInfoWindow OrderInfo = new OrderInfoWindow();
            OrderInfo.DataContext = sender;
            OrderInfo.Show();
        }
    }
    [ValueConversion(typeof(Int64), typeof(int))]
    public class OrderToPriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Int64 reValue = System.Convert.ToInt64(value);
            DataBase.OrderInfoModel info = new DataBase.OrderInfoModel();
            DataTable dt = info.GetByOrderid(reValue);
            DataRow[] Rows = dt.Select();
            int Allprice = 0;
            foreach (DataRow row in Rows)
            {
                int pr = (int)row["dish_price"];
                int num = (int)row["dish_num"];
                int price = pr * num;
                Allprice = Allprice + price;
            }
            return Allprice;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value.ToString();
            return value;
        }
    }
    [ValueConversion(typeof(string), typeof(string))]
    public class TickToTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            long reValue = System.Convert.ToInt64(value);
            DateTime dtime = DateTime.FromFileTime(reValue);
            string time = dtime.ToString();
            return time;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value.ToString();
            return value;
        }
    }
}
