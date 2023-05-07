namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllnewUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "User_Id", c => c.Int());
            CreateIndex("dbo.Tokens", "User_Id");
            AddForeignKey("dbo.Tokens", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "User_Id", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "User_Id" });
            DropColumn("dbo.Tokens", "User_Id");
        }
    }
}
