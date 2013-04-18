using System;
using System.Collections.Generic;
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

namespace server
{
	/// <summary>
	/// DishInfoWindow.xaml 的交互逻辑
	/// </summary>
	public partial class DishInfoWindow : Window
	{
		public DishInfoWindow()
		{
			this.InitializeComponent();
			
			// 在此点之下插入创建对象所需的代码。
		}
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            DishNameBox.IsEnabled = true;
            DishPriceBox.IsEnabled = true;
            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView RowView = (DataRowView)Window.DataContext;
            DataBase.DishModel dish = new DataBase.DishModel();
            dish.UpdateRow(RowView.Row);
            this.Close();
        }
	}
}