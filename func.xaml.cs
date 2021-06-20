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
    /// Логика взаимодействия для func.xaml
    /// </summary>
    public partial class func : Window
    {
        public func()
        {
            InitializeComponent();
        }
        uslugi Uslugi = new uslugi();
       
        
        
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

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }

        private void Window_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            Application.Current.Shutdown();
        }
    }
}
