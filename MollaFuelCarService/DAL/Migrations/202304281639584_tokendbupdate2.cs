namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tokendbupdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "Expired", c => c.DateTime());
            DropColumn("dbo.Tokens", "DeletedAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "DeletedAt", c => c.DateTime());
            DropColumn("dbo.Tokens", "Expired");
        }
    }
}
