namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class twotables12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResidentDetails", "VotingMembersId", c => c.Int(nullable: false));
            CreateIndex("dbo.ResidentDetails", "VotingMembersId");
            AddForeignKey("dbo.ResidentDetails", "VotingMembersId", "dbo.VotingMembers", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResidentDetails", "VotingMembersId", "dbo.VotingMembers");
            DropIndex("dbo.ResidentDetails", new[] { "VotingMembersId" });
            DropColumn("dbo.ResidentDetails", "VotingMembersId");
        }
    }
}
