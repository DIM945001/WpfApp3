﻿using System;
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
        func Funct = new func();

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

                    break;
                case "Инспектор":
                    Funct.listbut.Visibility = Visibility.Visible;
                    break;
                case "Бухгалтер":
                    Funct.listbut.Visibility = Visibility.Visible;
                    Funct.taskbut.Visibility = Visibility.Visible;
                    break;

            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Пользователь авторизовался", comboBox.Text); // говорим, что авторизовался
            this.Close();
            Funct.Show();


        }
    }
}
