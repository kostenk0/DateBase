using HappyTravel.Models;
using HappyTravel.Tools;
using HappyTravel.Tools.Managers;
using HappyTravel.Tools.Navigation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HappyTravel.ViewModels
{
    internal class SignInViewModel : BaseViewModel
    {
        #region Fields
        private string _login;
        private string _password;

        #region Commands
        private RelayCommand<object> _signInCommand;
        private RelayCommand<object> _signUpCommand;
        private RelayCommand<object> _closeCommand;
        #endregion
        #endregion

        #region Properties
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Commands

        public RelayCommand<object> SignInCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand<object>(
                           o =>
                           {
                               if(string.IsNullOrWhiteSpace(_login))
                               {
                                   MessageBox.Show("Login is empty!");
                                   return;
                               }
                               if(string.IsNullOrWhiteSpace(_password))
                               {
                                   MessageBox.Show("Password is empty!");
                                   return;
                               }
                               string connStr = "server=us-cdbr-gcp-east-01.cleardb.net;user=b08c8f9d8c7549;database=gcp_b59f698ea7b4607d7c34;password=1ab93de2;";
                               MySqlConnection conn = new MySqlConnection(connStr);
                               try
                               {
                                   string sql = "SELECT * FROM users WHERE login=@login and password=@password";
                                   MySqlCommand comand = new MySqlCommand(sql, conn);
                                   comand.Parameters.AddWithValue("@login", Login);
                                   comand.Parameters.AddWithValue("@password", Password);
                                   conn.Open();
                                   MySqlDataReader dr = comand.ExecuteReader();
                                   if (dr.HasRows == true)
                                   {
                                       dr.Read();
                                       var login = dr.GetString(0);
                                       var password = dr.GetString(1);
                                       StationManager.CurrentUser = new User(login, password);
                                       NavigationManager.Instance.Navigate(ViewType.MainManager);
                                   }
                                   else
                                   {
                                       MessageBox.Show($"User with {Login} doesnt exist!");
                                   }
                               }
                               catch (Exception e)
                               {
                                   MessageBox.Show(e.Message);
                               }
                           }));
            }
        }

        public RelayCommand<Object> SignUpCommand
        {
            get
            {
                return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(
                           o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.SignUp);
                           }));
            }
        }

        public RelayCommand<Object> CloseCommand
        {
            get
            {
                return _closeCommand ?? (_closeCommand = new RelayCommand<object>(o => StationManager.CloseApp()));
            }
        }

        #endregion
    }
}