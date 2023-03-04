using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int AvaliQuantity { get; set; }
        public Status Status { get; set; }
    }
}

namespace InventorySys.Models
{
    public enum Status
    {
        Ok,Defective
    }
}