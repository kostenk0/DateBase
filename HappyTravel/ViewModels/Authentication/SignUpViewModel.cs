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

namespace HappyTravel.ViewModels.Authentication
{
    internal class SignUpViewModel : BaseViewModel
    {
        #region Fields
        private string _login;
        private string _password;

        #region Commands
        private RelayCommand<object> _backToSignInCommand;
        private RelayCommand<object> _signUpCommand;
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

        public RelayCommand<object> BackToSignInCommand
        {
            get
            {
                return _backToSignInCommand ?? (_backToSignInCommand = new RelayCommand<object>(
                           o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.SignIn);
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
                               if (string.IsNullOrWhiteSpace(_login))
                               {
                                   MessageBox.Show("Login is empty!");
                                   return;
                               }
                               if (string.IsNullOrWhiteSpace(_password))
                               {
                                   MessageBox.Show("Password is empty!");
                                   return;
                               }
                               string connStr = "server=us-cdbr-gcp-east-01.cleardb.net;user=b08c8f9d8c7549;database=gcp_b59f698ea7b4607d7c34;password=1ab93de2;";
                               MySqlConnection conn = new MySqlConnection(connStr);
                               try
                               {
                                   conn.Open();
                                   MySqlCommand comm = conn.CreateCommand();
                                   comm.CommandText = "INSERT INTO users(login,password) VALUES(?login,?password)";
                                   comm.Parameters.Add("?login", MySqlDbType.VarChar).Value = Login;
                                   comm.Parameters.Add("?password", MySqlDbType.VarChar).Value = Password;
                                   comm.ExecuteNonQuery();
                                   MessageBox.Show("Successful!");
                               }
                               catch (Exception e)
                               {
                                   MessageBox.Show(e.Message);
                               }
                               finally
                               {
                                   conn.Close();
                               }
                           }));
            }
        }
        #endregion
    }
}
