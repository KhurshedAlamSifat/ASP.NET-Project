namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Picture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Picture");
        }
    }
}
