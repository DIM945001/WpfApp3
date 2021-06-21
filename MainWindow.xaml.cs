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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }
        Class1 c1 = new Class1();

        //public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        // {
        // DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
        // подключаемся к базе данных
        // SqlConnection sqlConnection = new SqlConnection("server=CAB212-2\\MSSQLSERVER20;Trusted_Connection=yes;DataBase=AUTH;");
        // sqlConnection.Open();                                           // открываем базу данных
        // SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
        // sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
        // SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
        // sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом

        // return dataTable;

        // }

       
        private void button_Click(object sender, RoutedEventArgs e)
        {


            //if (textbox1.Text.Length > 0) // проверяем введён ли логин     
            //{
            //    if (textbox2.Password.Length > 0) // проверяем введён ли пароль         
            //    {             // ищем в базе данных пользователя с такими данными         
            //        DataTable dt_user = Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + textbox1.Text + "' AND [password] = '" + textbox2.Password + "'");
            //        if (dt_user.Rows.Count > 0) // если такая запись существует       
            //        {
        
            switch (comboBox.Text)
            {
                case "Клиент":
                    c1.Funct.label1.Content = "Клиент";
                    c1.Funct.listbut.Visibility = Visibility.Hidden;
                    c1.Funct.taskbut.Visibility = Visibility.Hidden;
                    break;
                case "Инспектор":
                    c1.Funct.uslug_but.Visibility = Visibility.Hidden;
                    c1.Funct.listbut.Visibility = Visibility.Visible;
                    c1.Funct.label1.Content = "Инспектор";
                    break;
                case "Бухгалтер":
                    c1.Funct.listbut.Visibility = Visibility.Visible;
                    c1.Funct.taskbut.Visibility = Visibility.Visible;
                    c1.Funct.label1.Content = "Бухгалтер";
                    break;

            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Пользователь авторизовался", comboBox.Text); // говорим, что авторизовался
            this.Visibility = Visibility.Hidden;
            try
            {
                c1.Funct.ShowDialog();
                    if (DATA.b == 1)
            {
                this.Visibility = Visibility.Visible;
            }
                DATA.b = 0;
            }
            catch
            {
                
               // c1.Funct.Visibility = Visibility.Visible;
                
            }
            

        }

    
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

