using System;
using System.Collections.Generic;

namespace UTN.FRCU.ISI.TdP.AccountManager.Domain
{
    public class Account
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public double OverdraftLimit { get; set; }

        public double GetBalance()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            throw new NotImplementedException();
        }

    }
}
