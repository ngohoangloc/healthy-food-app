using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_api_healthy_food.Data
{
    [Table("roles")]
    public class Role
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public List<User> users { get; set; }

        public List<Privilege> privileges { get; set; }

    }
}
