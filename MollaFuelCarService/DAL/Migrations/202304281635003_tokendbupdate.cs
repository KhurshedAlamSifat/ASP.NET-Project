namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tokendbupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tokens", "DeletedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tokens", "DeletedAt", c => c.DateTime(nullable: false));
        }
    }
}
