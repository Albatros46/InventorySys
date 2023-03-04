﻿using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
    public class PurchaseOrderLine
    {
        public int Id { get; set; }
        [Display(Name ="Purchase Order")]
        public int PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }

        [Display(Name = "Discount Percentage")]
        public double DiscountPercentage { get; set; }

        [Display(Name = "Discount Amount")]
        public double DiscountAmount { get; set; }

        [Display(Name = "Sub Total")]
        public double SubTotal { get; set; }

        [Display(Name = "Tax Percentage")]
        public double TaxPercentage { get; set; }

        [Display(Name = "Tax Amount")]
        public double TaxAmount { get; set; }

        [Display(Name = "Total")]
        public double Total { get; set; }

    }
}
