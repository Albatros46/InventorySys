using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name="Branch")]
        public int BranchId { get; set; }
    }
}
