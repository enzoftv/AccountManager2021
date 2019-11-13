using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework
{
    public class ClientRepository : Repository<Client, AccountManagerDbContext>, IClientRepository
    {

        public ClientRepository(AccountManagerDbContext pDbContext) : base(pDbContext)
        {

        }


    }
}
