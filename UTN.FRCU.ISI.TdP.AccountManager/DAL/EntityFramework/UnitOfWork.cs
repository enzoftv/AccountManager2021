using System;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AccountManagerDbContext iDbContext;

        private bool iDisposedValue = false;

        public UnitOfWork(AccountManagerDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new NotImplementedException();
            }

            this.iDbContext = pDbContext;
            this.AccountRepository = new AccountRepository(pDbContext);
            this.ClientRepository = new ClientRepository(pDbContext);
        }

        public IAccountRepository AccountRepository { get; private set; }

        public IClientRepository ClientRepository { get; private set; }

        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

    }
}
