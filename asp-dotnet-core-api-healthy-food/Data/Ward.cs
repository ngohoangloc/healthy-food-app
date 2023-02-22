using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_api_healthy_food.Data
{
    [Table("wards")]
    public class Ward
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        public District district { get; set; }

    }
}
