using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardMVC.Models
{
    public class Supervisor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupervisorID { get; set; }
        public string Name { get; set; }
        public virtual DoeUser DoeUser { get; set;}
    }
}