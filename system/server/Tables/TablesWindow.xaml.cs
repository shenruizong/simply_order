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
    /// TablesWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TablesWindow : Window
    {
        public TablesWindow()
        {
            InitializeComponent();
        }
        private DataTable TableDataTable;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataBase.TablesModel tables = new DataBase.TablesModel();
            TableDataTable =tables.SelectAll();
            TablesList.ItemsSource = TableDataTable.DefaultView;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataRow row = TableDataTable.NewRow();
            AddWindow add = new AddWindow();
            add.DataContext = row;
            if (add.ShowDialog().Value)
            {
                TableDataTable.Rows.Add(row);
                DataBase.TablesModel tables = new DataBase.TablesModel();
                tables.AddTable(TableDataTable);
                TableDataTable.Clear();
                TableDataTable = tables.SelectAll();
                TablesList.ItemsSource = TableDataTable.DefaultView;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            EditWindow edit = new EditWindow();
            edit.DataContext = but.DataContext;
            edit.Show();
        }
        
    }
}
