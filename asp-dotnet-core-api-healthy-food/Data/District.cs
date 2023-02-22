using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_api_healthy_food.Data
{
    [Table("districts")]
    public class District
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public List<Ward> wards { get; set; }
    }
}
