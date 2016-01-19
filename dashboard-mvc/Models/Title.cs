using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardMVC.Models
{
    public class Title
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TitleID { get; set; }
        public string Name { get; set; }
    }
}