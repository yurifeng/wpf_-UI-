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

namespace yty_wpf_180508_02
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Button btn = new Button();
            //btn.Content = "哈啊哈。。。";

            //sp1.Children.Add(btn);

            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                gridName.ColumnDefinitions.Add(cd);

                RowDefinition rd = new RowDefinition();
                gridName.RowDefinitions.Add(rd);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Content = i + "," + j;

                    //通过代码修改控件的Grid.Row
                    Grid.SetRow(btn, i);
                    //通过代码修改控件的Grid.Column
                    Grid.SetColumn(btn, j);

                    gridName.Children.Add(btn);

                    
                }
            }
        }

        private void sp1_MouseEnter(object sender, MouseEventArgs e)
        {
            //Button btn2 = new Button();
            //btn2.Content = "偶吼吼。。。";

            //sp1.Children.Add(btn2);
        }
    }
}
