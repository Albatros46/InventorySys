using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
    public class CustomerType
    {
        public int Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        public string Description { get; set; }
    }
}
