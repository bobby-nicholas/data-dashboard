namespace dashboard_mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        DoeUserInfo_DoeUserID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DoeUserInfoes", t => t.DoeUserInfo_DoeUserID)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.DoeUserInfo_DoeUserID);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.DoeUserInfoes",
                c => new
                    {
                        DoeUserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FullName = c.String(),
                        Supervisor_SupervisorID = c.Int(),
                        Team_TeamID = c.Int(),
                        Title_TitleID = c.Int(),
                    })
                .PrimaryKey(t => t.DoeUserID)
                .ForeignKey("dbo.Supervisors", t => t.Supervisor_SupervisorID)
                .ForeignKey("dbo.Teams", t => t.Team_TeamID)
                .ForeignKey("dbo.Titles", t => t.Title_TitleID)
                .Index(t => t.Supervisor_SupervisorID)
                .Index(t => t.Team_TeamID)
                .Index(t => t.Title_TitleID);
            
            CreateTable(
                "dbo.LcgmsSchoolDatas",
                c => new
                    {
                        Dbn = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        BedsNumber = c.String(),
                        ManagedBy = c.String(),
                        TypeDescription = c.String(),
                        CategoryDescription = c.String(),
                        Grades = c.String(),
                        OpenDate = c.String(),
                        Status = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Principal = c.String(),
                        PrincipalTitle = c.String(),
                        PrincipalEmail = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        GeoDistrictCode = c.String(),
                        AdminDistrictCode = c.String(),
                        DistrictLocationCode = c.String(),
                        DistrictName = c.String(),
                        Superintendent = c.String(),
                        SuperintendentLocationCode = c.String(),
                        SuperintendentEmail = c.String(),
                        CommunitySupName = c.String(),
                        CommunitySupEmail = c.String(),
                        BfscLocationCode = c.String(),
                        BfscDirectorName = c.String(),
                        BfscDirectorTitle = c.String(),
                        BfscDirectorPhone = c.String(),
                        BfscDirectorEmail = c.String(),
                        HsNetworkLocationCode = c.String(),
                        HsNetworkName = c.String(),
                        HsNetworkSuperintendent = c.String(),
                        ProseSchool = c.String(),
                        DoeUserInfo_DoeUserID = c.Int(),
                    })
                .PrimaryKey(t => t.Dbn)
                .ForeignKey("dbo.DoeUserInfoes", t => t.DoeUserInfo_DoeUserID)
                .Index(t => t.DoeUserInfo_DoeUserID);
            
            CreateTable(
                "dbo.Supervisors",
                c => new
                    {
                        SupervisorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DoeUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SupervisorID)
                .ForeignKey("dbo.AspNetUsers", t => t.DoeUser_Id)
                .Index(t => t.DoeUser_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TeamID);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        TitleID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TitleID);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "DoeUserInfo_DoeUserID", "dbo.DoeUserInfoes");
            DropForeignKey("dbo.DoeUserInfoes", "Title_TitleID", "dbo.Titles");
            DropForeignKey("dbo.DoeUserInfoes", "Team_TeamID", "dbo.Teams");
            DropForeignKey("dbo.DoeUserInfoes", "Supervisor_SupervisorID", "dbo.Supervisors");
            DropForeignKey("dbo.Supervisors", "DoeUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.LcgmsSchoolDatas", "DoeUserInfo_DoeUserID", "dbo.DoeUserInfoes");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.Supervisors", new[] { "DoeUser_Id" });
            DropIndex("dbo.LcgmsSchoolDatas", new[] { "DoeUserInfo_DoeUserID" });
            DropIndex("dbo.DoeUserInfoes", new[] { "Title_TitleID" });
            DropIndex("dbo.DoeUserInfoes", new[] { "Team_TeamID" });
            DropIndex("dbo.DoeUserInfoes", new[] { "Supervisor_SupervisorID" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "DoeUserInfo_DoeUserID" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.Titles");
            DropTable("dbo.Teams");
            DropTable("dbo.Supervisors");
            DropTable("dbo.LcgmsSchoolDatas");
            DropTable("dbo.DoeUserInfoes");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
