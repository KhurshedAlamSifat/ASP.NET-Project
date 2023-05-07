namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updat37 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tokens", "UserId", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "UserId" });
            DropColumn("dbo.Tokens", "Username");
            RenameColumn(table: "dbo.Tokens", name: "UserId", newName: "Username");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Tokens", "Username", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Tokens", "Username", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Username");
            CreateIndex("dbo.Tokens", "Username");
            AddForeignKey("dbo.Tokens", "Username", "dbo.Users", "Username", cascadeDelete: true);
            DropColumn("dbo.Users", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Tokens", "Username", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "Username" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Username", c => c.String());
            AlterColumn("dbo.Tokens", "Username", c => c.Int(nullable: false));
            AlterColumn("dbo.Tokens", "Username", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Users", "Id");
            RenameColumn(table: "dbo.Tokens", name: "Username", newName: "UserId");
            AddColumn("dbo.Tokens", "Username", c => c.String(nullable: false));
            CreateIndex("dbo.Tokens", "UserId");
            AddForeignKey("dbo.Tokens", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
