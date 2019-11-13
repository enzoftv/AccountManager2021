using System.Data.Entity;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework
{
    public class AccountManagerDbContext : DbContext
    {

        public IDbSet<Client> Clients { get; set; }

        public IDbSet<Account> Accounts { get; set; }

        public IDbSet<AccountMovement> AccountMovements { get; set; }

    }
}
