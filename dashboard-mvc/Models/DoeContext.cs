using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DashboardMVC.Models
{
    public class DoeContext : IdentityDbContext<DoeUser>
    {
        public DoeContext() : base("DefaultConnection") { }
        //public virtual DbSet<DoeUser> DoeUsers { get; set; }
        //public virtual DbSet<Supervisor> Supervisors { get; set; }
        //public virtual DbSet<LcgmsSchoolData> LcgmsSchools { get; set; }
        //public virtual DbSet<Title> Titles { get; set; }
        //public virtual DbSet<Team> Teams { get; set; }
    }
}