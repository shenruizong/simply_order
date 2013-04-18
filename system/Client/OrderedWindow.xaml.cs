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
    /// OrderedWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OrderedWindow : Window
    {
        public OrderedWindow()
        {
            InitializeComponent();
        }
        public DataRowView TableRow { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int table_id = (int)TableRow["id"];
            DataBase.OrdersModel orders = new DataBase.OrdersModel();
            string Order_num = orders.TableToOrder_num(table_id);
            DataTable OrderList = orders.Order_numToOrder_info(Order_num);
            OrderListView.ItemsSource = OrderList.DefaultView;
            OrderNumBlock.Text = Order_num;
            TableNameBlock.Text = (string)TableRow["name"];


        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckOutButton_Click(object sender, RoutedEventArgs e)
        {
            CheckOutWindow check = new CheckOutWindow();
            if (check.ShowCheck(TableRow).Value)
            {
                this.Close();
            }

        }

        private void TurnTableButton_Click(object sender, RoutedEventArgs e)
        {
            TurnTableWindow turn = new TurnTableWindow();
            turn.TableRow = TableRow;
            if (turn.ShowDialog().Value)
            {
                this.Close();
            }
        }
    }
}
