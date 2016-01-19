using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dashboard_mvc.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DashboardMVC.Models
{
    public class DoeUser : IdentityUser {
        public virtual DoeUserInfo DoeUserInfo { get; set; }
    }

    public class DoeUserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoeUserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName { get; set; }
        public virtual Title Title { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public virtual Team Team { get; set; }
        public virtual List<LcgmsSchoolData> Schools { get; set; }
        public virtual List<DoeBuilding> WorkSites { get; set; }
    }
}