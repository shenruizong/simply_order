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
    /// ClosingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ClosingWindow : Window
    {
        public ClosingWindow()
        {
            InitializeComponent();
            create_list();
        }
        private void create_list()
        {
            List<closing> list = new List<closing>()
            {
                new closing{table_name="桌台3",order_num="201304142127"}
            };
            listView1.ItemsSource = list;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new ClosingSelWindow().Show();
        }
    }
    class closing
    {
        public string table_name { get; set; }
        public string order_num { get; set; }
    }
}
