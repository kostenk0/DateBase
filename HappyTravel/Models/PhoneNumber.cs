using System;

namespace HappyTravel.Models

{
    [Serializable]
    internal class PhoneNumber
    {
        #region Fields
        private string _number;
        private string _clientCode;
        #endregion

        #region Properties
        public string Number { get => _number; set => _number = value; }
        public string ClientCode { get => _clientCode; set => _clientCode = value; }
        #endregion

        #region Constructor
        internal PhoneNumber(string number, string clientCode)
        {
            this.Number = number;
            this.ClientCode = clientCode;
        }
        #endregion
    }
}