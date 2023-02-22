using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_api_healthy_food.Data
{
    [Table("privileges")]
    public class Privilege
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public List<Role> roles { get; set; } 
    }
}
