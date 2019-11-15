using System;
using System.Collections.Generic;
using System.Linq;

namespace UTN.FRCU.ISI.TdP.AccountManager.Domain
{
    public class Account
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public double OverdraftLimit { get; set; }

        public virtual IList<AccountMovement> Movements { get; set; } = new List<AccountMovement>();

        public double GetBalance()
        {
            return (from movement in this.Movements select movement.Amount).Sum();
        }

        public IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            return this.Movements.OrderByDescending(pMovement => pMovement.Date).Take(pCount);
        }

    }
}
