namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vote8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "VotingStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "VotingStatus");
        }
    }
}
