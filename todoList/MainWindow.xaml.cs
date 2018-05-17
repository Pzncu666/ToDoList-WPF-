using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace todoList
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            // 產生新方塊
            TDItem item = new TDItem();
            
            // 放到TDS
            TDS.Children.Add(item);
        }

        private void saveBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 裝所有文字的變數
            List<string> all = new List<string>();

            // 取得item的文字
            foreach ( TDItem item in TDS.Children)
            {
                all.Add(item.GetTaskName());
            }

            // 存檔
            System.IO.File.WriteAllLines(@"c:\tododata.txt", all);
        }



    }
}
