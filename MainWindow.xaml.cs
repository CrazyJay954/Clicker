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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        long point = 6666;
        static int click = 1;
        int pwns = 1;
        double sol_b1 = 10 + 10 * (30 + click * 0.2);
        double sol_b2 = 20 + 20 * (60 + click * 0.4);
        double sol_b3 = 30 + 30 * (90 + click * 0.6);
        

        public MainWindow()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            poi.Content = "Очков: " + point;
            cli.Content = "Очков за клик: " + click;
            b1.Content = (sol_b1).ToString();
            b2.Content = (sol_b2).ToString();
            b3.Content = (sol_b3).ToString();
        }


        private void Src1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += click;
            Update();
        }

        private void b1_Click_1(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b1))
            {
                point -= Convert.ToInt64(Math.Round(sol_b1));
                click += 3;
                Update();
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b2))
            {
                point -= Convert.ToInt64(Math.Round(sol_b2));
                click += 6;
                Update();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b3))
            {
                point -= Convert.ToInt64(Math.Round(sol_b3));
                click +=9;
                Update();
            }
        }

        public void Timer_Tick(object sender, EventArgs e) 
        {
            point += pwns;
            Update();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b1))
            {
                point -= Convert.ToInt64(Math.Round(sol_b1));
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                timer.Start();
                Update();
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b2))
            {
                point -= Convert.ToInt64(Math.Round(sol_b2));
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                pwns += 2;
                timer.Start();
                Update();
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b3))
            {
                point -= Convert.ToInt64(Math.Round(sol_b3));
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                pwns += 3;
                timer.Start();
                Update();
            }
        }
    }
    
}
