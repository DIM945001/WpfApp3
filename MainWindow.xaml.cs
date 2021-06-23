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
        String pwd = "";

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
        private  void auth_delay()
        {
            
        }

        private async void dd()
        {
            
            while (i < DATA.c)
            {
                button.IsEnabled = false;
                await Task.Delay(4000);
                button.IsEnabled = true;
                i ++;
            }
            i = 0;
        }
        int sss = 0;
        double i = 0;
        string login = "login";
        string pass = "qwerty";
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.Text != "")
            {
                if (login == textBox.Text)
                {
                    if (pass == passwordBox.Password)
                    {
                        if (textbox12.Text == label4.Content.ToString())
                        {
                            MessageBox.Show("Вы авторизованы");
                            DATA.trueLogin = true;
                        }
                        else
                        {
                            sss += 4;
                            MessageBox.Show("Неверная капча, вход будет заблокирован на " + sss + " секунд");
                            DATA.c += 1;
                            dd();
                        }
                    }
                    else
                    {
                        if (passwordBox.Password == "")
                        {
                            sss += 4;
                            MessageBox.Show("где пароль, вход будет заблокирован на " + sss + " секунд");
                            DATA.c += 1;
                            dd();
                        }
                        else
                        {
                            sss += 4;
                            MessageBox.Show("неверный пароль, вход будет заблокирован на " + sss + " секунд");
                            DATA.c += 1;
                            dd();
                        }
                    }
                }
                else
                {
                    if (textBox.Text == "")
                    {
                        sss += 4;
                        MessageBox.Show("где логин, вход будет заблокирован на " + sss + " секунд");
                        DATA.c += 1;
                        dd(); 
                        
                        
                    }
                    else
                    {
                        sss += 4;
                        MessageBox.Show("неверный логин, вход будет заблокирован на " + sss + " секунд");
                      DATA.c += 1;
                      dd();
                    }
                }



                //if (textbox1.Text.Length > 0) // проверяем введён ли логин     
                //{
                //    if (textbox2.Password.Length > 0) // проверяем введён ли пароль         
                //    {             // ищем в базе данных пользователя с такими данными         
                //        DataTable dt_user = Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + textbox1.Text + "' AND [password] = '" + textbox2.Password + "'");
                //        if (dt_user.Rows.Count > 0) // если такая запись существует       
                //        {
                if (DATA.trueLogin == true)
                {
                    
                    switch (comboBox.Text)
                    {
                        case "Клиент":
                            c1.Funct.label1.Text = "Андреев Дмитрий Алексеевич ,Клиент";
                            c1.Funct.uslug_but.IsEnabled = true;
                            c1.Funct.listbut.IsEnabled = false;
                            c1.Funct.taskbut.IsEnabled = false;
                            break;
                        case "Инспектор":
                            c1.Funct.uslug_but.IsEnabled = false;
                            c1.Funct.listbut.IsEnabled = true;
                            c1.Funct.taskbut.IsEnabled = false;
                            c1.Funct.label1.Text = "Андреев Дмитрий Алексеевич ,Инспектор";
                            break;
                        case "Бухгалтер":
                            c1.Funct.uslug_but.IsEnabled = false;
                            c1.Funct.listbut.IsEnabled = false;
                            c1.Funct.taskbut.IsEnabled = true;
                            c1.Funct.label1.Text = "Андреев Дмитрий Алексеевич ,Бухгалтер";
                            break;


                    }
                    //  MessageBoxResult messageBoxResult = MessageBox.Show("Пользователь авторизовался", comboBox.Text); // говорим, что авторизовался
                    this.Visibility = Visibility.Hidden;
                    try
                    {
                        c1.Funct.ShowDialog();
                        if (DATA.b == 1)
                        {
                            this.Visibility = Visibility.Visible;
                            passwordBox.Password = null;
                            textBox.Text = null;
                            textbox12.Text = null;
                            comboBox.Text = null;
                            pwd = null;
                            label4.Content = "";
                            cap();
                        }
                        DATA.b = 0;
                    }
                    catch
                    {

                        // c1.Funct.Visibility = Visibility.Visible;

                    }

                }
                else
                {
                    return;
                }
            }
            else
            {

                DATA.trueLogin = false;
                MessageBox.Show("Не выбрана роль");

            }
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        void cap()
        {
            {

                String allowchar = " "; // там будет символ вместо пробела

                allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

                allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";

                allowchar += "1,2,3,4,5,6,7,8,9,0";

                char[] a = { ',' }; 

               String[] ar = allowchar.Split(a); //



                string temp = " "; //

                Random r = new Random(); 



                for (int i = 0; i < 4; i++) // 

                {

                    temp = ar[(r.Next(0, ar.Length))];



                    pwd += temp;

                }

                label4.Content = pwd;

            }
        }
       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cap();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Checked(object sender, RoutedEventArgs e)
        {
            textBlock.Text = passwordBox.Password;
            textBlock.Visibility = Visibility.Visible;
            passwordBox.Visibility = Visibility.Hidden;
            button1.Content = "*";
            button1.Foreground = Brushes.LightGray;
        }

        private void button1_Unchecked(object sender, RoutedEventArgs e)
        {
            textBlock.Visibility = Visibility.Hidden;
            passwordBox.Visibility = Visibility.Visible;
            button1.Content = "A";
            button1.Foreground = Brushes.Gray;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            pwd = null;
            label4.Content = "";
            cap();
        }
    }
    }


