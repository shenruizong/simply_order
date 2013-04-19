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
    /// EditWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView RowView = (DataRowView)this.DataContext;
            RowView.Delete();
            DataBase.TablesModel tables = new DataBase.TablesModel();
            tables.UpdateRow(RowView.Row);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            TableNameBox.IsEnabled = true;
            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView RowView = (DataRowView)this.DataContext;
            RowView["name"] = TableNameBox.Text;
            DataBase.TablesModel tables = new DataBase.TablesModel();
            tables.UpdateRow(RowView.Row);
            this.Close();
        }
    }
}
