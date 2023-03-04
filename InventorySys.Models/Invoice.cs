using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
    public class Invoice
    {//Fatura
        public int Id { get; set; }
        [Display(Name="Invoice Number")]
        public string Name { get; set; }
        [Display(Name= "Shipment")]
        public int ShipmentId { get; set; }
        [Display(Name= "Invoice Date")]
        public DateTimeOffset InvoiceDate { get; set; }
        [Display(Name= "Invoice Due Date")]
        public DateTimeOffset InvoiceDueDate { get; set; }//datura son odeme tarihi
        [Display(Name ="Invoice Type")]
        public int InvoiceTypeId { get; set; }
    }
}
