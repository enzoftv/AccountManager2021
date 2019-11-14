using System;
using System.Collections.Generic;
using UTN.FRCU.ISI.TdP.AccountManager.IO;

namespace UTN.FRCU.ISI.TdP.AccountManager
{
    public class Bank
    {

        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAccountId)
        {
            throw new NotImplementedException();
        }

    }
}
