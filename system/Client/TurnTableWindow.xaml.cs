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
    /// TurnTableWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TurnTableWindow : Window
    {
        public TurnTableWindow()
        {
            InitializeComponent();
        }
        public DataRowView TableRow;
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {

            DataBase.TablesModel tables = new DataBase.TablesModel();
            DataRowView FirRow = (DataRowView)FirTableBlock.DataContext;
            DataRowView SecRow = (DataRowView)SecTableBlock.DataContext;
            tables.TurnTable(FirRow, SecRow);
            this.DialogResult = true;
            Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataBase.TablesModel tables = new DataBase.TablesModel();
            DataTable dt = tables.GetFreeTable();
            TablesList.ItemsSource = dt.DefaultView;
            FirTableBlock.DataContext = TableRow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            SecTableBlock.DataContext = but.DataContext;
            
        }
    }
}
