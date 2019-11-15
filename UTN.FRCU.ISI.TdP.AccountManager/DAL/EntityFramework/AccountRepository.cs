using System.Collections.Generic;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework
{
    public class AccountRepository : Repository<Account, AccountManagerDbContext>, IAccountRepository
    {

        public AccountRepository(AccountManagerDbContext pDbContext) : base(pDbContext)
        {

        }

        public IEnumerable<Account> GetOverdrawnAccounts()
        {
            IList<Account> mOverdrawnAccounts = new List<Account>();

            foreach (var bAccount in this.GetAll())
            {
                var bAccountBalance = bAccount.GetBalance();

                if (bAccountBalance < 0 && System.Math.Abs(bAccountBalance) > bAccount.OverdraftLimit)
                {
                    mOverdrawnAccounts.Add(bAccount);
                }
            }

            return mOverdrawnAccounts;
        }
    }
}
