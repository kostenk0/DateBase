namespace HappyTravel.Models
{
    internal class User
    {
        #region Fields
        private string _login;
        private string _password;
        #endregion

        #region Constructors
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        #endregion

        #region Properties
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; } 
        #endregion
    }
}