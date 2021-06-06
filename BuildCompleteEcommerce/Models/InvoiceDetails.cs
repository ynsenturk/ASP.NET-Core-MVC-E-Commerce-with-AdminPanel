using System.ComponentModel.DataAnnotations.Schema;

namespace BuildCompleteEcommerce.Models
{
    [Table("InvoiceDetails")]
    public class InvoiceDetails
    {
        public int InvoiceId { get; set; }

        public int ProductId { get; set; }
        
        public decimal Price { get; set; }
        
        public int Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }

    }
}
