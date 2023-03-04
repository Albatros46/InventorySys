using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Customer Type")]
        public int CustomerTypeId { get; set; }
        [Display(Name="Street Adress")]
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name ="Zip Code")]
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Contact Person")]
        public string ContaktPerson { get; set; }
    }
}
