using System;

namespace HappyTravel.Models
{
    [Serializable]
    internal class Pass
    {
        #region Fields
        private int _passNumber;
        private string _status;
        private int _number_of_people;
        private decimal _price;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _duration;
        private int _contractNumber;
        #endregion

        #region Properties
        public int PassNumber { get => _passNumber; set => _passNumber = value; }
        public string Status { get => _status; set => _status = value; }
        public int NumberOfPeople { get => _number_of_people; set => _number_of_people = value; }
        public decimal Price { get => _price; set => _price = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public int ContractNumber { get => _contractNumber; set => _contractNumber = value; }

        #endregion

        #region Constructor
        public Pass(int passNumber, string status, int numberOfPeople, decimal price, DateTime startDate, DateTime endDate, int duration, int contractNumber)
        {
            PassNumber = passNumber;
            Status = status;
            NumberOfPeople = numberOfPeople;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            Duration = duration;
            ContractNumber = contractNumber;
        }
        #endregion
    }
}