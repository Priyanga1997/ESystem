namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class twotables1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ResidentDetails", "VotingMembers_id", "dbo.VotingMembers");
            DropIndex("dbo.ResidentDetails", new[] { "VotingMembers_id" });
            DropColumn("dbo.ResidentDetails", "VotingMemberId");
            DropColumn("dbo.ResidentDetails", "VotingMembers_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ResidentDetails", "VotingMembers_id", c => c.Int());
            AddColumn("dbo.ResidentDetails", "VotingMemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.ResidentDetails", "VotingMembers_id");
            AddForeignKey("dbo.ResidentDetails", "VotingMembers_id", "dbo.VotingMembers", "id");
        }
    }
}
