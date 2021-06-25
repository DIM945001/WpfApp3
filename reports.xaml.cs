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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для reports.xaml
    /// </summary>
    public partial class reports : Window
    {
        public reports()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }
        private async void button2_Click(object sender, RoutedEventArgs e) // проверка оплаты (кастыль)
        {
            button2.Content = "Проверка оплаты...";
            await Task.Delay(3000);
            button2.Content = "Оплачено";

        }

        private async void button21_Click(object sender, RoutedEventArgs e) // проверка оплаты (кастыль)
        {
            MessageBox.Show(DATA.reportbuffer);

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
