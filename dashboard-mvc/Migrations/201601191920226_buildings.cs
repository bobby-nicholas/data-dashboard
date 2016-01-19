namespace dashboard_mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buildings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DoeBuildings",
                c => new
                    {
                        BuildingID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        DoeUserInfo_DoeUserID = c.Int(),
                    })
                .PrimaryKey(t => t.BuildingID)
                .ForeignKey("dbo.DoeUserInfoes", t => t.DoeUserInfo_DoeUserID)
                .Index(t => t.DoeUserInfo_DoeUserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DoeBuildings", "DoeUserInfo_DoeUserID", "dbo.DoeUserInfoes");
            DropIndex("dbo.DoeBuildings", new[] { "DoeUserInfo_DoeUserID" });
            DropTable("dbo.DoeBuildings");
        }
    }
}
