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

namespace server.Tables
{
    /// <summary>
    /// AddWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            DataRow row = (DataRow)this.DataContext;
            row["name"] = DishNameBox.Text;
            row["type_id"] = 1;
            Close();
        }
    }
}
