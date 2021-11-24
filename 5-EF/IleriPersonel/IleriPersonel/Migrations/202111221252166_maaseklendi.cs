namespace IleriPersonel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maaseklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calisan", "Maas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calisan", "Maas");
        }
    }
}
