using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppUserManagementSystem.Ui
{
    public class OverSeasAddress
    {
        private int overSeasAddressId;
        private string street;
        private string state;
        private string postalCode;
        private string userId;

        public string OUserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public int ForeignAddressId
        {
            get { return overSeasAddressId; }
            set { overSeasAddressId = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
    }
}
