namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNullableConstraintsAndStringLength : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Artist_Id", "dbo.Artists");
            DropForeignKey("dbo.Gigs", "Genra_Id", "dbo.Genras");
            DropIndex("dbo.Gigs", new[] { "Artist_Id" });
            DropIndex("dbo.Gigs", new[] { "Genra_Id" });
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gigs", "Artist_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Gigs", "Genra_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Artists", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Genras", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Gigs", "Artist_Id");
            CreateIndex("dbo.Gigs", "Genra_Id");
            AddForeignKey("dbo.Gigs", "Artist_Id", "dbo.Artists", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Gigs", "Genra_Id", "dbo.Genras", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Genra_Id", "dbo.Genras");
            DropForeignKey("dbo.Gigs", "Artist_Id", "dbo.Artists");
            DropIndex("dbo.Gigs", new[] { "Genra_Id" });
            DropIndex("dbo.Gigs", new[] { "Artist_Id" });
            AlterColumn("dbo.Genras", "Name", c => c.String());
            AlterColumn("dbo.Artists", "Name", c => c.String());
            AlterColumn("dbo.Gigs", "Genra_Id", c => c.Byte());
            AlterColumn("dbo.Gigs", "Artist_Id", c => c.Guid());
            AlterColumn("dbo.Gigs", "Venue", c => c.String());
            CreateIndex("dbo.Gigs", "Genra_Id");
            CreateIndex("dbo.Gigs", "Artist_Id");
            AddForeignKey("dbo.Gigs", "Genra_Id", "dbo.Genras", "Id");
            AddForeignKey("dbo.Gigs", "Artist_Id", "dbo.Artists", "Id");
        }
    }
}
