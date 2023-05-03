namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sm3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceManOrderlists",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderFor = c.String(nullable: false, maxLength: 20),
                        OrderTime = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceManOrderlists");
        }
    }
}
