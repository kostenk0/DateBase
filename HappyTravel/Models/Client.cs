using System;

namespace HappyTravel.Models
{
    [Serializable]
    internal class Client
    {
        #region Fields
        private int _clientCode;
        private string _pasportNumber;
        private string _surname;
        private string _name;
        private string _fathersName;
        private DateTime _birthDate;
        private int _age;
        private string _email;
        #endregion

        #region Properties
        public int ClientCode { get => _clientCode; set => _clientCode = value; }
        public string PasportNumber { get => _pasportNumber; set => _pasportNumber = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Name { get => _name; set => _name = value; }
        public string FathersName { get => _fathersName; set => _fathersName = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public int Age { get => _age; set => _age = value; }
        public string Email { get => _email; set => _email = value; }
        #endregion

        #region Constructor
        internal Client(int clientCode, string pasportNumber, string surname, string name, string fathersName, DateTime birthDate, int age, string email)
        {
            this.ClientCode = clientCode;
            this.PasportNumber = pasportNumber;
            this.Surname = surname;
            this.Name = name;
            this.FathersName = fathersName;
            this.BirthDate = birthDate;
            this.Age = age;
            this.Email = email;
        }
        #endregion
    }
}