namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genras",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Gigs", "Genra_Id", c => c.Byte());
            CreateIndex("dbo.Gigs", "Genra_Id");
            AddForeignKey("dbo.Gigs", "Genra_Id", "dbo.Genras", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Genra_Id", "dbo.Genras");
            DropIndex("dbo.Gigs", new[] { "Genra_Id" });
            DropColumn("dbo.Gigs", "Genra_Id");
            DropTable("dbo.Genras");
        }
    }
}
