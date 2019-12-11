namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        EducationDetails = c.String(),
                        OccupationDetails = c.String(),
                        PreviousRWAMember = c.Boolean(nullable: false),
                        PartOfGovOrNgoOrPolice = c.Boolean(nullable: false),
                        CriminalRecord = c.Boolean(nullable: false),
                        PositionForElectionsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PositionForElections", t => t.PositionForElectionsId, cascadeDelete: true)
                .Index(t => t.PositionForElectionsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "PositionForElectionsId", "dbo.PositionForElections");
            DropIndex("dbo.Registrations", new[] { "PositionForElectionsId" });
            DropTable("dbo.Registrations");
        }
    }
}
