using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DashboardMVC.Models
{
    public class LcgmsSchoolData
    {
        [Key()]
        [Display(Name ="DBN")]
        public string Dbn { get; set; }
        [Display(Name = "School Name")]
        public string Name { get; set; }
        [Display(Name = "BEDS Number")]
        public string BedsNumber { get; set; }
        [Display(Name = "Managed By")]
        public string ManagedBy { get; set; }
        [Display(Name = "Type Description")]
        public string TypeDescription { get; set; }
        [Display(Name = "Category Description")]
        public string CategoryDescription { get; set; }
        public string Grades { get; set; }
        [Display(Name = "Open Date")]
        public string OpenDate { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Principal { get; set; }
        [Display(Name = "Principal Title")]
        public string PrincipalTitle { get; set; }
        [Display(Name = "Principal Email")]
        public string PrincipalEmail { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }
        [Display(Name = "Geographical District Code")]
        public string GeoDistrictCode { get; set; }
        [Display(Name = "Administrative District Code")]
        public string AdminDistrictCode { get; set; }
        [Display(Name = "District Location Code")]
        public string DistrictLocationCode { get; set; }
        [Display(Name = "District Name")]
        public string DistrictName { get; set; }
        public string Superintendent { get; set; }
        [Display(Name = "Superintendent Location Code")]
        public string SuperintendentLocationCode { get; set; }
        [Display(Name = "Superintendent Email")]
        public string SuperintendentEmail { get; set; }
        [Display(Name = "Community School Sup. Name")]
        public string CommunitySupName { get; set; }
        [Display(Name = "Community School Sup. Email")]
        public string CommunitySupEmail { get; set; }
        [Display(Name = "BFSC Location Code")]
        public string BfscLocationCode { get; set; }
        [Display(Name = "BFSC Director Name")]
        public string BfscDirectorName { get; set; }
        [Display(Name = "BFSC Director Title")]
        public string BfscDirectorTitle { get; set; }
        [Display(Name = "BFSC Director Phone")]
        public string BfscDirectorPhone { get; set; }
        [Display(Name = "BFSC Director Email")]
        public string BfscDirectorEmail { get; set; }
        [Display(Name = "High School Network Location Code")]
        public string HsNetworkLocationCode { get; set; }
        [Display(Name = "High School Network Name")]
        public string HsNetworkName { get; set; }
        [Display(Name = "High School Network Superintendent")]
        public string HsNetworkSuperintendent { get; set; }
        [Display(Name = "Prose School")]
        public string ProseSchool { get; set; }

        public virtual List<DoeUser> Members { get; set; }
    }
}