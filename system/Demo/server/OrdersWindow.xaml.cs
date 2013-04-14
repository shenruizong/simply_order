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
    /// OrdersWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OrdersWindow : Window
    {
        public OrdersWindow()
        {
            InitializeComponent();
            Create_list();
        }
        private void Create_list()
        {
            List<orderList> list = new List<orderList>()
            {
                new orderList{order_num="201304141727",order_price="2280￥",create_time="2013-04-14 17:27",finish_time="2013-04-14 21:28"}
            };
            dataGrid1.ItemsSource = list;
        }
    }
    class orderList
    {
        public string order_num { get; set; }
        public string order_price { get; set; }
        public string create_time { get; set; }
        public string finish_time { get; set; }
    }
}
