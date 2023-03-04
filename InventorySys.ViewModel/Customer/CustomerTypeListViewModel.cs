using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.ViewModel.Customer
{
    public class CustomerTypeListViewModel
    {
        public int Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        public string Description { get; set; }
    }
}
