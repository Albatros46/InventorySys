﻿namespace InventorySys.Models
{
    public class SalesOrderLine
    {
        public int Id { get; set; }
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }//One to one-> iliskisi
        public int ProductId { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public double DiscountPercentage { get; set; }
        public double DiscountAmount { get; set; }
        public double SubTotal { get; set; }
        public double TaxPercentage { get; set; }
        public double TaxAmount { get; set; }
        public double Total { get; set; }

        
    }
}
