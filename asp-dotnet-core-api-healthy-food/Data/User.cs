using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_api_healthy_food.Data
{
    [Table("users")]
    public class User
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        [Required]
        [StringLength(20)]
        public string password { get; set; }

        [Required]
        public List<Role> roles { get; set; }

        public Profile profile { get; set; }
    }
}
