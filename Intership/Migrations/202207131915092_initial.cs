namespace Intership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cameras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        Model = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhotoURL = c.String(),
                        Rating = c.Int(nullable: false),
                        CameraId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cameras", t => t.CameraId)
                .Index(t => t.CameraId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "CameraId", "dbo.Cameras");
            DropIndex("dbo.Photos", new[] { "CameraId" });
            DropTable("dbo.Photos");
            DropTable("dbo.Cameras");
        }
    }
}
