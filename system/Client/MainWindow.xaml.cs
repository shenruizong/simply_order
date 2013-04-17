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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Globalization;

namespace Client
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataBase.TablesModel tables = new DataBase.TablesModel();
            DataTable AllTable = tables.SelectAll();
            TablesList.ItemsSource = AllTable.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            DataRowView TableRow = (DataRowView)but.DataContext;
            int type_id = (int)TableRow["type_id"];
            if (type_id == 1)//未开台
            {
                OpenWindow open = new OpenWindow();
                open.TableRow = TableRow;
                open.Show();
            }
            else
            {
                MessageBox.Show("急什么！还没开发呢！");
            }
        }
    }
    [ValueConversion(typeof(int), typeof(String))]
    public class TableColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int reValue = System.Convert.ToInt32(value);
            string BackValue= "#FF6FF940";//初始化为开台
            if (reValue == 2)//已开台
            {
                BackValue = "Red";
            }
            return BackValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value.ToString();
            return value;
        }
    }
}
