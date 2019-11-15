using AutoMapper;
using System.Collections.Generic;
using UTN.FRCU.ISI.TdP.AccountManager.DAL;
using UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;
using UTN.FRCU.ISI.TdP.AccountManager.IO;

namespace UTN.FRCU.ISI.TdP.AccountManager
{
    public class Bank
    {

        private static readonly IMapper cMapper;

        static Bank()
        {
            var mConfiguration = new MapperConfiguration(pConfiguration =>
            {
                pConfiguration.CreateMap<AccountMovement, AccountMovementDTO>();
            });

            cMapper = mConfiguration.CreateMapper();
        }

        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId)
        {
            IList<AccountDTO> mAccounts;

            using (var bDbContext = new AccountManagerDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    var bClient = bUoW.ClientRepository.Get(pClientId);

                    if (bClient != null && bClient.Accounts.Count > 0)
                    {
                        mAccounts = new List<AccountDTO>(bClient.Accounts.Count);

                        foreach (var bAccount in bClient.Accounts)
                        {
                            mAccounts.Add(new AccountDTO
                            {
                                Id = bAccount.Id,
                                Name = bAccount.Name,
                                Balance = bAccount.GetBalance(),
                                OverDraftLimit = bAccount.OverdraftLimit
                            });
                        }
                    }
                    else
                    {
                        mAccounts = new List<AccountDTO>();
                    }
                }
            }

            return mAccounts;
        }

        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAccountId)
        {
            IList<AccountMovementDTO> mAccountMovements;

            using (var bDbContext = new AccountManagerDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    var bAccount = bUoW.AccountRepository.Get(pAccountId);

                    if (bAccount != null && bAccount.Movements.Count > 0)
                    {
                        mAccountMovements = cMapper.Map<IList<AccountMovementDTO>>(bAccount.Movements);
                    }
                    else
                    {
                        mAccountMovements = new List<AccountMovementDTO>();
                    }
                }
            }

            return mAccountMovements;
        }

    }
}
