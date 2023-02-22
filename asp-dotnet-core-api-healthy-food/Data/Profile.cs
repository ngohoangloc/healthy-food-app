using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_api_healthy_food.Data
{
    [Table("profiles")]
    public class Profile
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        public string lastName { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(10)]
        public char phone { get; set; }

        [Required]
        public User user { get; set; }
    }
}
