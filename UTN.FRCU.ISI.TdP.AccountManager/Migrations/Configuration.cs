namespace UTN.FRCU.ISI.TdP.AccountManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.AccountManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.AccountManagerDbContext";
        }

        protected override void Seed(UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.AccountManagerDbContext pContext)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
