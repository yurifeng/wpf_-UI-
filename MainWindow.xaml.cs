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
                //内存new列定义
                ColumnDefinition cd = new ColumnDefinition();
                //gridName的列自行添加10次
                gridName.ColumnDefinitions.Add(cd);

                //内存new行定义
                RowDefinition rd = new RowDefinition();
                //gridName的行自行添加10次
                gridName.RowDefinitions.Add(rd);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Button btn = new Button();
            //        btn.Content = i + "," + j;

            //        //通过代码修改控件的Grid.Row
            //        Grid.SetRow(btn, i);
            //        //通过代码修改控件的Grid.Column
            //        Grid.SetColumn(btn, j);

            //        gridName.Children.Add(btn);


            //    }
            //}

            Random r = new Random();
            //前闭后开区间
            //随机生成一个大于等于0，小于99的随机整数
            //int hehe = r.Next(0, 99);
            


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    //随机生成1到9之间的数字，也就是图片
                    int imgNum = r.Next(1, 10);
                    
                    //new出image控件
                    Image img = new Image();
                    //引用图片
                    img.Source = new BitmapImage(new Uri("img/" + imgNum + ".png", UriKind.Relative));
                    //设置行图片
                    Grid.SetRow(img, i);
                    //设置列图片
                    Grid.SetColumn(img, j);
                    gridName.Children.Add(img);
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
