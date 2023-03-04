﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Vendor Type")]
        public int VendorTypeId { get; set; }
        [Display(Name = "Street Adress")]
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

    }
}
