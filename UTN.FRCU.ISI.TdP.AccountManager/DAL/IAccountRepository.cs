using System.Collections.Generic;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL
{
    public interface IAccountRepository : IRepository<Account>
    {

        IEnumerable<Account> GetOverdrawnAccounts();

    }
}
