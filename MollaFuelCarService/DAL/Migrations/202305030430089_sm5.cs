namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sm5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceManHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product = c.String(nullable: false, maxLength: 20),
                        SupplierName = c.String(nullable: false, maxLength: 20),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceManHistories");
        }
    }
}
