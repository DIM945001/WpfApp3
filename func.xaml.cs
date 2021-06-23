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
using System.Windows.Shapes;
using System.Threading;
using System.Timers;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для func.xaml
    /// </summary>
    public partial class func : Window
    {
        public func()
        {
            
            
            InitializeComponent();
        }
        uslugi Uslugi = new uslugi();
        public int ss = 600;


        public void DisplayTimeEvent(object source, EventArgs e)
            {
            
            ss--;
            label2.Text ="время сеанса " + ss + "с ";
            if (ss == 300)
            {
                MessageBox.Show("Через 5 минут будет автоматический выход из системы");
            }
        }


        private void timerTick(object sender, EventArgs e)
        {

            App.Current.Shutdown();
        }



        public string a;

        private void uslug_but_Click(object sender, RoutedEventArgs e)
        {

            Uslugi.Show();
        }

        private void listbut_Click(object sender, RoutedEventArgs e)
        {

            Uslugi.client.Show();
        }

        private void taskbut_Click(object sender, RoutedEventArgs e)
        {
            Uslugi.client.Reports.Show();
        }

        

        private void Window_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Shutdown();
         //   e.Cancel = true;
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            DATA.b = 1;
            Hide();
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer myTimer = new System.Windows.Threading.DispatcherTimer();
            myTimer.Tick += new EventHandler(DisplayTimeEvent);
            myTimer.Interval = new TimeSpan(0, 0, 1); // 1000 ms is one second
            myTimer.Start();

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 10, 0);
            timer.Start();

            
        }
    }
}

