namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admin_partModified : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Admins");
            AddColumn("dbo.Tokens", "UserType", c => c.String());
            AlterColumn("dbo.Admins", "Username", c => c.String(nullable: false, maxLength: 100));
            AddPrimaryKey("dbo.Admins", "Username");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Admins");
            AlterColumn("dbo.Admins", "Username", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Tokens", "UserType");
            AddPrimaryKey("dbo.Admins", "Username");
        }
    }
}
