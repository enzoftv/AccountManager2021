using System;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL
{
    public interface IUnitOfWork : IDisposable
    {

        IAccountRepository AccountRepository { get; }

        IClientRepository ClientRepository { get; }

        void Complete();

    }
}
