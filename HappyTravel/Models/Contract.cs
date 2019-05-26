using System;

namespace HappyTravel.Models
{
    internal class Contract
    {
        #region Fields
        private string _contractNumber;
        private DateTime _dateOfMaking;
        private string _clientCode;
        #endregion

        #region Properties
        public string ClientCode { get => _clientCode; set => _clientCode = value; }
        public DateTime DateOfMaking { get => _dateOfMaking; set => _dateOfMaking = value; }
        public string ContractNumber { get => _contractNumber; set => _contractNumber = value; }
        #endregion

        #region Constructor
        internal Contract(string contractNumber, DateTime dateOfMaking, string clientCode)
        {
            this.ContractNumber = contractNumber;
            this.DateOfMaking = dateOfMaking;
            this.ClientCode = clientCode;
        }
        #endregion
    }
}