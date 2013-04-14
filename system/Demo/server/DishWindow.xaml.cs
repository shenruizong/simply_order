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
    /// DishWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DishWindow : Window
    {
        public DishWindow()
        {
            InitializeComponent();
            List<dish> dish = new List<dish>()
            {
                new dish{name = "菜品1",price="99￥"},
                new dish{name = "菜品2",price="99￥"},
                new dish{name = "菜品3",price="99￥"},
                new dish{name = "菜品4",price="99￥"},
                new dish{name = "菜品5",price="99￥"},
                new dish{name = "菜品6",price="99￥"},
                new dish{name = "菜品7",price="99￥"},
                new dish{name = "菜品8",price="99￥"},
                new dish{name = "菜品9",price="99￥"},
            };
            listView1.ItemsSource = dish;
        }
    }
    class dish
    {
        public string name{ get; set; }
        public string price{ get; set; }
    }
}
