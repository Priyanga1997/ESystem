namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class votescolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "Votes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "Votes");
        }
    }
}
