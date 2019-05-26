namespace HappyTravel.Models
{
    internal class Ticket
    {
        #region Fields
        private string _numberOfTicket;
        private int _seat;
        private string _typeOfSeat;
        private int _car;
        private int _row;
        private string _passNumber;
        private string _tripNumber;
        #endregion

        #region Properties
        public string NumberOfTicket { get => _numberOfTicket; set => _numberOfTicket = value; }
        public int Seat { get => _seat; set => _seat = value; }
        public string TypeOfSeat { get => _typeOfSeat; set => _typeOfSeat = value; }
        public int Car { get => _car; set => _car = value; }
        public int Row { get => _row; set => _row = value; }
        public string PassNumber { get => _passNumber; set => _passNumber = value; }
        public string TripNumber { get => _tripNumber; set => _tripNumber = value; }
        #endregion

        #region Constructors
        public Ticket(string numberOfTicket, int seat, string typeOfSeat, int car, int row, string passNumber, string tripNumber)
        {
            NumberOfTicket = numberOfTicket;
            Seat = seat;
            TypeOfSeat = typeOfSeat;
            Car = car;
            Row = row;
            PassNumber = passNumber;
            TripNumber = tripNumber;
        }
        #endregion
    }


}