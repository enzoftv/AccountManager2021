using System.Data.Entity.ModelConfiguration;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.Mapping
{
    class AccountMap : EntityTypeConfiguration<Account>
    {

        public AccountMap()
        {
            this.HasKey(pAccount => pAccount.Id);

            this.Property(pAccount => pAccount.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(pAccount => pAccount.Name)
                .HasMaxLength(20)
                .IsRequired();

            this.Property(pAccount => pAccount.OverdraftLimit)
                .IsRequired();

            this.HasMany(pClient => pClient.Movements)
                .WithRequired();
        }

    }
}
