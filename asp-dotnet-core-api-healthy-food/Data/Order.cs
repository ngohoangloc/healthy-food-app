using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_dotnet_core_api_healthy_food.Data
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double total { get; set; }

        [StringLength(150)]
        public string note { get; set; }

        [Required]
        public DateTime time { get; set; }

        [Required]
        public User user { get; set; }
    }
}
