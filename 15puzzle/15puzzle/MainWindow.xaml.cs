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

namespace _15puzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<int> list = new List<int>();

        private int img1 = 1;
        private int img2 = 2;
        private int img3 = 3;
        private int img4 = 4;
        private int img5 = 5;
        private int img6 = 6;
        private int img7 = 7;
        private int img8 = 8;
        private int img9 = 9;
        private int img10 = 10;
        private int img11 = 11;
        private int img12 = 12;
        private int img13 = 13;
        private int img14 = 14;
        private int img15 = 15;
        private int img16 = 16;

        public MainWindow()
        {
            InitializeComponent();

            refresh();

        }

        private void refresh()
        {
            img_1.Source = new BitmapImage(new Uri(@"Images/img" + img1 + ".jpg", UriKind.Relative));
            img_2.Source = new BitmapImage(new Uri(@"Images/img" + img2 + ".jpg", UriKind.Relative));
            img_3.Source = new BitmapImage(new Uri(@"Images/img" + img3 + ".jpg", UriKind.Relative));
            img_4.Source = new BitmapImage(new Uri(@"Images/img" + img4 + ".jpg", UriKind.Relative));
            img_5.Source = new BitmapImage(new Uri(@"Images/img" + img5 + ".jpg", UriKind.Relative));
            img_6.Source = new BitmapImage(new Uri(@"Images/img" + img6 + ".jpg", UriKind.Relative));
            img_7.Source = new BitmapImage(new Uri(@"Images/img" + img7 + ".jpg", UriKind.Relative));
            img_8.Source = new BitmapImage(new Uri(@"Images/img" + img8 + ".jpg", UriKind.Relative));
            img_9.Source = new BitmapImage(new Uri(@"Images/img" + img9 + ".jpg", UriKind.Relative));
            img_10.Source = new BitmapImage(new Uri(@"Images/img" + img10 + ".jpg", UriKind.Relative));
            img_11.Source = new BitmapImage(new Uri(@"Images/img" + img11 + ".jpg", UriKind.Relative));
            img_12.Source = new BitmapImage(new Uri(@"Images/img" + img12 + ".jpg", UriKind.Relative));
            img_13.Source = new BitmapImage(new Uri(@"Images/img" + img13 + ".jpg", UriKind.Relative));
            img_14.Source = new BitmapImage(new Uri(@"Images/img" + img14 + ".jpg", UriKind.Relative));
            img_15.Source = new BitmapImage(new Uri(@"Images/img" + img15 + ".jpg", UriKind.Relative));
            img_16.Source = new BitmapImage(new Uri(@"Images/img" + img16 + ".jpg", UriKind.Relative));
        }

        private void shuffle()
        {
            var rnd = new Random();
            for (int i = 1; i < 16; i++) 
            {
                int n = rnd.Next(i + 1);
                int temp = rnd[i];
                1[i] = 1[n];
                1[n] = temp;
            }

            img1 = list[1];
            img2 = list[2];
            img3 = list[3];
            img4 = list[4];
            img5 = list[5];
            img6 = list[6];
            img7 = list[7];
            img8 = list[8];
            img9 = list[9];
            img10 = list[10];
            img11 = list[11];
            img12 = list[12];
            img13 = list[13];
            img14 = list[14];
            img15 = list[15];
            img16 = list[16];

        }

        private void Img01_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img2 == 16)
            {
                img2 = img1;
                img1 = 16;
            }
            refresh();
            if (img5 == 16)
            {
                img5 = img1;
                img1 = 16;
            }
            refresh();
        }

        private void Img02_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img1 == 16)
            {
                img1 = img2;
                img2 = 16;
            }
            refresh();
            if (img3 == 16)
            {
                img3 = img2;
                img2 = 16;
            }
            refresh();
            if (img6 == 16)
            {
                img6 = img2;
                img2 = 16;
            }
            refresh();
        }

        private void Img03_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img2 == 16)
            {
                img2 = img3;
                img3 = 16;
            }
            refresh();
            if (img4 == 16)
            {
                img4 = img3;
                img3 = 16;
            }
            refresh();
            if (img7 == 16)
            {
                img7 = img3;
                img3 = 16;
            }
            refresh();
        }

        private void Img04_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img3 == 16)
            {
                img3 = img4;
                img4 = 16;
            }
            refresh();
            if (img8 == 16)
            {
                img8 = img4;
                img4 = 16;
            }
            refresh();
        }

        private void Img05_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img1 == 16)
            {
                img1 = img5;
                img5 = 16;
            }
            refresh();
            if (img6 == 16)
            {
                img6 = img5;
                img5 = 16;
            }
            refresh();
            if (img9 == 16)
            {
                img9 = img5;
                img5 = 16;
            }
            refresh();
        }

        private void Img06_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img2 == 16)
            {
                img2 = img6;
                img6 = 16;
            }
            refresh();
            if (img5 == 16)
            {
                img5 = img6;
                img6 = 16;
            }
            refresh();
            if (img7 == 16)
            {
                img7 = img6;
                img6 = 16;
            }
            refresh();
            if (img10 == 16)
            {
                img10 = img6;
                img6 = 16;
            }
            refresh();
        }

        private void Img07_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img3 == 16)
            {
                img3 = img7;
                img7 = 16;
            }
            refresh();
            if (img6 == 16)
            {
                img6 = img7;
                img7 = 16;
            }
            refresh();
            if (img8 == 16)
            {
                img8 = img7;
                img7 = 16;
            }
            refresh();
            if (img11 == 16)
            {
                img11 = img7;
                img7 = 16;
            }
            refresh();
        }

        private void Img08_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img4 == 16)
            {
                img4 = img8;
                img8 = 16;
            }
            refresh();
            if (img7 == 16)
            {
                img7 = img8;
                img8 = 16;
            }
            refresh();
            if (img12 == 16)
            {
                img12 = img8;
                img8 = 16;
            }
            refresh();
        }

        private void Img09_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img5 == 16)
            {
                img5 = img9;
                img9 = 16;
            }
            refresh();
            if (img10 == 16)
            {
                img10 = img9;
                img9 = 16;
            }
            refresh();
            if (img13 == 16)
            {
                img13 = img9;
                img9 = 16;
            }
            refresh();
        }

        private void Img10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img6 == 16)
            {
                img6 = img10;
                img10 = 16;
            }
            refresh();
            if (img9 == 16)
            {
                img9 = img10;
                img10 = 16;
            }
            refresh();
            if (img11 == 16)
            {
                img11 = img10;
                img10 = 16;
            }
            refresh();
            if (img14 == 16)
            {
                img14 = img10;
                img10 = 16;
            }
            refresh();
        }

        private void Img11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img7 == 16)
            {
                img7 = img11;
                img11 = 16;
            }
            refresh();
            if (img10 == 16)
            {
                img10 = img11;
                img11 = 16;
            }
            refresh();
            if (img12 == 16)
            {
                img12 = img11;
                img11 = 16;
            }
            refresh();
            if (img15 == 16)
            {
                img15 = img11;
                img11 = 16;
            }
            refresh();
        }

        private void Img12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img8 == 16)
            {
                img8 = img12;
                img12 = 16;
            }
            refresh();
            if (img11 == 16)
            {
                img11 = img12;
                img12 = 16;
            }
            refresh();
            if (img16 == 16)
            {
                img16 = img12;
                img12 = 16;
            }
            refresh();
        }

        private void Img13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img9 == 16)
            {
                img9 = img13;
                img13 = 16;
            }
            refresh();
            if (img14 == 16)
            {
                img14 = img13;
                img13 = 16;
            }
            refresh();
        }

        private void Img14_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img10 == 16)
            {
                img10 = img14;
                img14 = 16;
            }
            refresh();
            if (img13 == 16)
            {
                img13 = img14;
                img14 = 16;
            }
            refresh();
            if (img15 == 16)
            {
                img15 = img14;
                img14 = 16;
            }
            refresh();
        }

        private void Img15_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img11 == 16)
            {
                img11 = img15;
                img15 = 16;
            }
            refresh();
            if (img14 == 16)
            {
                img14 = img15;
                img15 = 16;
            }
            refresh();
            if (img16 == 16)
            {
                img16 = img15;
                img15 = 16;
            }
            refresh();
        }

        private void img_16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (img14 == 16)
            {
                img14 = img16;
                img16 = 16;
            }
            refresh();
            if (img15 == 16)
            {
                img15 = img16;
                img16 = 16;
            }
            refresh();
        }
    }
}
