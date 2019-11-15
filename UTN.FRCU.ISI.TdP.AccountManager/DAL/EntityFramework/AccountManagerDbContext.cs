using System.Data.Entity;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;
using UTN.FRCU.ISI.TdP.AccountManager.Migrations;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework
{
    public class AccountManagerDbContext : DbContext
    {

        public AccountManagerDbContext() : base("AccountManager")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AccountManagerDbContext, Configuration>());
        }

        public IDbSet<Client> Clients { get; set; }

        public IDbSet<Account> Accounts { get; set; }

        public IDbSet<AccountMovement> AccountMovements { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());

            base.OnModelCreating(pModelBuilder);
        }

    }
}
