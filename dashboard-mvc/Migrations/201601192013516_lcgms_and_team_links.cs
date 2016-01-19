namespace dashboard_mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lcgms_and_team_links : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LcgmsSchoolData_Dbn", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Team_TeamID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "LcgmsSchoolData_Dbn");
            CreateIndex("dbo.AspNetUsers", "Team_TeamID");
            AddForeignKey("dbo.AspNetUsers", "LcgmsSchoolData_Dbn", "dbo.LcgmsSchoolDatas", "Dbn");
            AddForeignKey("dbo.AspNetUsers", "Team_TeamID", "dbo.Teams", "TeamID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Team_TeamID", "dbo.Teams");
            DropForeignKey("dbo.AspNetUsers", "LcgmsSchoolData_Dbn", "dbo.LcgmsSchoolDatas");
            DropIndex("dbo.AspNetUsers", new[] { "Team_TeamID" });
            DropIndex("dbo.AspNetUsers", new[] { "LcgmsSchoolData_Dbn" });
            DropColumn("dbo.AspNetUsers", "Team_TeamID");
            DropColumn("dbo.AspNetUsers", "LcgmsSchoolData_Dbn");
        }
    }
}
