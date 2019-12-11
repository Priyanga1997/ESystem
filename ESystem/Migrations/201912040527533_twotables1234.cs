namespace ESystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class twotables1234 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResidentDetails", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResidentDetails", "Name");
        }
    }
}
