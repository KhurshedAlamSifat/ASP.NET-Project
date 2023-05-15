namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAdminTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Admins");
            AddPrimaryKey("dbo.Admins", "Username");
            DropColumn("dbo.Admins", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Admins");
            AddPrimaryKey("dbo.Admins", "Id");
        }
    }
}
