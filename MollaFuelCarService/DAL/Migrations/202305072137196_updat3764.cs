namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updat3764 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tokens", "User_Id", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "User_Id" });
            RenameColumn(table: "dbo.Tokens", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Tokens", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tokens", "UserId");
            AddForeignKey("dbo.Tokens", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "UserId", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "UserId" });
            AlterColumn("dbo.Tokens", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Tokens", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Tokens", "User_Id");
            AddForeignKey("dbo.Tokens", "User_Id", "dbo.Users", "Id");
        }
    }
}
