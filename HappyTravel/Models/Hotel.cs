namespace HappyTravel.Models
{
    internal class Hotel
    {
        #region Fields
        private string _hotelCode;
        private string _title;
        private string _classification;
        private string _describe;
        private string _resortCode;
        #endregion

        #region Constructors
        public Hotel(string hotelCode, string title, string classification, string describe, string resortCode)
        {
            HotelCode = hotelCode;
            Title = title;
            Classification = classification;
            Describe = describe;
            ResortCode = resortCode;
        }
        #endregion

        #region Properties
        public string HotelCode { get => _hotelCode; set => _hotelCode = value; }
        public string Title { get => _title; set => _title = value; }
        public string Classification { get => _classification; set => _classification = value; }
        public string Describe { get => _describe; set => _describe = value; }
        public string ResortCode { get => _resortCode; set => _resortCode = value; } 
        #endregion
    }
}