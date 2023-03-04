using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
 
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [Display(Name = "Masure Unit")]
        public int MasureUnitId { get; set; }
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }
        [Display(Name ="Branch")]
        public int BranchId { get; set; }
        [Display(Name ="Currency")]
        public int CurrencyId { get; set; }
    }
}
