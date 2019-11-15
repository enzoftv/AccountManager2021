namespace UTN.FRCU.ISI.TdP.AccountManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientDocument : DbMigration
    {
        public override void Up()
        {
            Random mRandom = new Random();
            
            AddColumn("dbo.Clients", "DocumentType", c => c.Int(nullable: false, defaultValue: 0));
            AddColumn("dbo.Clients", "DocumentNumber", c => c.String(nullable: false, maxLength: 20, defaultValue: mRandom.Next().ToString()));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "DocumentNumber");
            DropColumn("dbo.Clients", "DocumentType");
        }
    }
}
