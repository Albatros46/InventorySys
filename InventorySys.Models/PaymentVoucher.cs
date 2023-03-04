using System.ComponentModel.DataAnnotations;

namespace InventorySys.Models
{
    public class PaymentVoucher
    {//Ödeme Makbuzu
        public int Id { get; set; }
        [Display(Name="Payment Voucher Number")]
        public string Name { get; set; }

        [Display(Name = "Bill")]
        public int BillId { get; set; }

        [Display(Name = "Payment Date")]
        public DateTimeOffset PaymentDate { get; set; }

        [Display(Name = "Payment Type")]
        public int PaymentTypeId { get; set; }

        [Display(Name = "Payment Amount")]
        public double PaymentAmount { get; set; }

        [Display(Name = "Payment Source")]
        public int CashBankId { get; set; }

        [Display(Name = "Full Payment")]
        public bool IsfullPayment { get; set; } = true;
    }
}
