namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class twotables12345 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResidentDetails", "ResidentId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResidentDetails", "ResidentId");
        }
    }
}
