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
    /// Логика взаимодействия для uslugi.xaml
    /// </summary>
    public partial class uslugi : Window
    {
        public uslugi()
        {
            InitializeComponent();
            
            
        }
        public client client = new client();
        
        private void form_button_Click(object sender, RoutedEventArgs e)
        {
            label_fio.Visibility = Visibility.Visible;
            fio.Visibility = Visibility.Visible;
            send.Visibility = Visibility.Visible;
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            

            MessageBox.Show("OK");
            DATA.buffer = fio.Text;
            
            client.clientlist.Items.Add(DATA.buffer);
            
         
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }

        private void Window_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; 
            Hide();
        }
    }
}
