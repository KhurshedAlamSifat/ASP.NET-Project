namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePicture : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Picture", c => c.Binary());
        }
    }
}
