namespace HappyTravel.Models
{
    internal class ContactPerson
    {
        #region Fields
        private int _contactPersonCode;
        private string _surname;
        private string name;
        private string _fathersName;
        private string _email;
        private string _resortCode;
    #endregion;

        #region Constructors
        public ContactPerson(int contactPersonCode, string surname, string name, string fathersName, string email, string resortCode)
        {
            ContactPersonCode = contactPersonCode;
            Surname = surname;
            this.Name = name;
            FathersName = fathersName;
            Email = email;
            ResortCode = resortCode;
        }
        #endregion

        #region Properties
        public int ContactPersonCode { get => _contactPersonCode; set => _contactPersonCode = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Name { get => name; set => name = value; }
        public string FathersName { get => _fathersName; set => _fathersName = value; }
        public string Email { get => _email; set => _email = value; }
        public string ResortCode { get => _resortCode; set => _resortCode = value; } 
        #endregion
    }
}