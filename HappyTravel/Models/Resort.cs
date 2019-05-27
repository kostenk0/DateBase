namespace HappyTravel.Models
{
    internal class Resort
    {
        #region Fields
        private string _resortCode;
        private string _title;
        private string _country;
        #endregion

        #region Constructors
        public Resort(string resortCode, string title, string country)
        {
            ResortCode = resortCode;
            Title = title;
            Country = country;
        }
        #endregion

        #region Properties
        public string ResortCode { get => _resortCode; set => _resortCode = value; }
        public string Title { get => _title; set => _title = value; }
        public string Country { get => _country; set => _country = value; } 
        #endregion
    }
}