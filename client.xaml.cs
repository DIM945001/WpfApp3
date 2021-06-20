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
using System.Diagnostics;
using System.Threading;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для client.xaml
    /// </summary>
    public partial class client : Window
    {
        public reports Reports = new reports();
        public client()
        {

            
            
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string path = "C:\\Users\\DIMANI4\\Source\\Repos\\DIM945001\\_test_\\dogovor-dms.doc";
            Process.Start(path);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }

        private void Window_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            button2.Content = "Проверка оплаты...";
            await Task.Delay(3000);
            button2.Content = "Оплачено";
            
        }
    }
}
