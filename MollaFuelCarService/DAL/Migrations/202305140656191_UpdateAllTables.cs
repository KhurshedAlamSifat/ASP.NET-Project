namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(nullable: false, maxLength: 100),
                        Dob = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 100),
                        Location = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.FuelOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FuelType = c.String(nullable: false, maxLength: 50),
                        OrderedBy = c.String(nullable: false, maxLength: 128),
                        FOrderDate = c.DateTime(nullable: false),
                        DeliverAddress = c.String(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Status = c.String(nullable: false),
                        DeliveredBy = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.OrderedBy, cascadeDelete: true)
                .ForeignKey("dbo.DeliveryMen", t => t.DeliveredBy, cascadeDelete: true)
                .Index(t => t.OrderedBy)
                .Index(t => t.DeliveredBy);
            
            CreateTable(
                "dbo.DeliveryMen",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(nullable: false, maxLength: 100),
                        Dob = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 100),
                        Location = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderedBy = c.String(nullable: false, maxLength: 128),
                        OrderDate = c.DateTime(nullable: false),
                        DeliverAddress = c.String(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Status = c.String(nullable: false),
                        ServicedBy = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.OrderedBy, cascadeDelete: true)
                .ForeignKey("dbo.ServiceMen", t => t.ServicedBy, cascadeDelete: true)
                .Index(t => t.OrderedBy)
                .Index(t => t.ServicedBy);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Category = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.ServiceMen",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(nullable: false, maxLength: 100),
                        Dob = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 100),
                        Location = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
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
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        Expired = c.DateTime(),
                        Username = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Username, cascadeDelete: true)
                .Index(t => t.Username);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "Username", "dbo.Users");
            DropForeignKey("dbo.Orders", "ServicedBy", "dbo.ServiceMen");
            DropForeignKey("dbo.ProductOrders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductOrders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "OrderedBy", "dbo.Customers");
            DropForeignKey("dbo.FuelOrders", "DeliveredBy", "dbo.DeliveryMen");
            DropForeignKey("dbo.FuelOrders", "OrderedBy", "dbo.Customers");
            DropIndex("dbo.Tokens", new[] { "Username" });
            DropIndex("dbo.ProductOrders", new[] { "OrderId" });
            DropIndex("dbo.ProductOrders", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "ServicedBy" });
            DropIndex("dbo.Orders", new[] { "OrderedBy" });
            DropIndex("dbo.FuelOrders", new[] { "DeliveredBy" });
            DropIndex("dbo.FuelOrders", new[] { "OrderedBy" });
            DropTable("dbo.Users");
            DropTable("dbo.Tokens");
            DropTable("dbo.ServiceManOrderlists");
            DropTable("dbo.ServiceManHistories");
            DropTable("dbo.ServiceMen");
            DropTable("dbo.Products");
            DropTable("dbo.ProductOrders");
            DropTable("dbo.Orders");
            DropTable("dbo.DeliveryMen");
            DropTable("dbo.FuelOrders");
            DropTable("dbo.Customers");
            DropTable("dbo.Admins");
        }
    }
}
