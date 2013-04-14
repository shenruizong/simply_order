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
    /// OpenWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OpenWindow : Window
    {
        public OpenWindow()
        {
            InitializeComponent();
            List<Student> stuList = new List<Student>()                                                                                                                                                                                                                                                                  
        {                                                                                                                                                                                                                                                                  
            new Student(){name ="菜1",price=99,num=1},                                                                                                                                                                                                                                                                  
            new Student(){name ="菜2",price=99,num=1},                                                                                                                                                                                                                                                                  
            new Student(){name ="菜3",price=99,num=1},                                                                                                                                                                                                                                                                  
            new Student(){name ="菜4",price=99,num=1},                                                                                                                                                                                                                                                                  
            new Student(){name ="菜5",price=99,num=1},                                                                                                                                                                                                                                                                  
            new Student(){name ="菜6",price=99,num=1},                                                                                                                                                                                                                                                                  
        };
            listView1.ItemsSource = stuList;
        }
    }
    class Student
    {
        public string name { get; set; }
        public int price { get; set; }
        public int num { get; set; }
    }
}
