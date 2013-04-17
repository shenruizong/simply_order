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

namespace Client
{
    /// <summary>
    /// OpenWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OpenWindow : Window
    {
        public OpenWindow()
        {
            InitializeComponent();
        }
        public DataRowView TableRow { get; set; }
        public string Order_num { get; set; }
        DataTable Order_list;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Order_num = DateTime.Now.ToString("yyyyMMddHHmmss");
            OrderBlock.Text = Order_num;
            DataBase.DishModel dish = new DataBase.DishModel();
            DataTable dishlist = dish.SelectAll();
            DishList.ItemsSource = dishlist.DefaultView;
            InitOrderList();
            OrderListView.ItemsSource = Order_list.DefaultView;
        }
        private void InitOrderList()
        {
            Order_list = new DataTable();
            Order_list.Columns.Add("Dish_id", typeof(Int32));
            Order_list.Columns.Add("Dish_name", typeof(string));
            Order_list.Columns.Add("Dish_num", typeof(Int32));
            Order_list.Columns.Add("Dish_price", typeof(Int32));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            DataRowView DishRow = (DataRowView)but.DataContext;
            DataRow[] listSel = Order_list.Select("Dish_id = " + DishRow["id"]);
            if (listSel.Length == 1)
            {
                DataRow Listrow = listSel[0];
                int i = (int)Listrow["Dish_num"];
                Listrow["Dish_num"] = i + 1;
            }
            else
            {
                DataRow OrderList_Row = Order_list.NewRow();
                OrderList_Row["Dish_id"] = DishRow["id"];
                OrderList_Row["Dish_name"] = DishRow["name"];
                OrderList_Row["Dish_num"] = 1;
                OrderList_Row["Dish_price"] = DishRow["price"];
                Order_list.Rows.Add(OrderList_Row);
            }
        }
        private void CountPrice()
        {
 
        }
    }
}
