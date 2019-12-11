namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vote1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegistrationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registrations", t => t.RegistrationId, cascadeDelete: true)
                .Index(t => t.RegistrationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "RegistrationId", "dbo.Registrations");
            DropIndex("dbo.Votes", new[] { "RegistrationId" });
            DropTable("dbo.Votes");
        }
    }
}
