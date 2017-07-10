namespace Onlin_food_ordering_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Food : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        ContactNo = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
