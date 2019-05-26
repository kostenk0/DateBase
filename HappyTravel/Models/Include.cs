using System;

namespace HappyTravel.Models
{
    internal class Include
    {
        #region Fields
        private string _passNumber;
        private string _hotelCode;
        private string _typeOfApartment;
        private string _typeOfEating;
        private DateTime _dateOfSettlement;
        private DateTime _dateOfEviction;
        #endregion

        #region Properties
        public string PassNumber { get => _passNumber; set => _passNumber = value; }
        public string HotelCode { get => _hotelCode; set => _hotelCode = value; }
        public string TypeOfApartment { get => _typeOfApartment; set => _typeOfApartment = value; }
        public string TypeOfEating { get => _typeOfEating; set => _typeOfEating = value; }
        public DateTime DateOfSettlement { get => _dateOfSettlement; set => _dateOfSettlement = value; }
        public DateTime DateOfEviction { get => _dateOfEviction; set => _dateOfEviction = value; }
        #endregion

        #region Constructors
        public Include(string passNumber, string hotelCode, string typeOfApartment, string typeOfEating, DateTime dateOfSettlement, DateTime dateOfEviction)
        {
            PassNumber = passNumber;
            HotelCode = hotelCode;
            TypeOfApartment = typeOfApartment;
            TypeOfEating = typeOfEating;
            DateOfSettlement = dateOfSettlement;
            DateOfEviction = dateOfEviction;
        } 
        #endregion
    }
}