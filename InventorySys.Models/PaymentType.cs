using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
    public class PaymentType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
