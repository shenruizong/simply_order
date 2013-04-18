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
    /// CheckOutWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CheckOutWindow : Window
    {
        public CheckOutWindow()
        {
            InitializeComponent();
        }
        public DataRowView Table_row { get; set; }
        public bool? ShowCheck(DataRowView tabName)
        {
            var checkout = new CheckOutWindow();
            checkout.Table_row = tabName;
            return checkout.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TableNameBlock.Text = (string)Table_row["name"];
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            DataBase.TablesModel tables = new DataBase.TablesModel();
            tables.ChangeTableType(Table_row,3);
            this.Close();
        }

    }
}
