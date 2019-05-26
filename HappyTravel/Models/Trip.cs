using System;

namespace HappyTravel.Models
{
    internal class Trip
    {
        #region Fields
        private string _tripNumber;
        private string _name;
        private string _typeOfTransport;
        private string _placeOfDeparture;
        private string _placeOfArrival;
        private DateTime _departureDate;
        private DateTime _dateOfArrival;
        #endregion

        #region Properties
        public string TripNumber { get => _tripNumber; set => _tripNumber = value; }
        public string Name { get => _name; set => _name = value; }
        public string TypeOfTransport { get => _typeOfTransport; set => _typeOfTransport = value; }
        public string PlaceOfDeparture { get => _placeOfDeparture; set => _placeOfDeparture = value; }
        public string PlaceOfArrival { get => _placeOfArrival; set => _placeOfArrival = value; }
        public DateTime DepartureDate { get => _departureDate; set => _departureDate = value; }
        public DateTime DateOfArrival { get => _dateOfArrival; set => _dateOfArrival = value; }
        #endregion

        #region Constructors
        public Trip(string tripNumber, string name, string typeOfTransport, string placeOfDeparture, string placeOfArrival, DateTime departureDate, DateTime dateOfArrival)
        {
            TripNumber = tripNumber;
            Name = name;
            TypeOfTransport = typeOfTransport;
            PlaceOfDeparture = placeOfDeparture;
            PlaceOfArrival = placeOfArrival;
            DepartureDate = departureDate;
            DateOfArrival = dateOfArrival;
        }
        #endregion


    }
}