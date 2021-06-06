using System.ComponentModel.DataAnnotations.Schema;

namespace BuildCompleteEcommerce.Models
{
    [Table("Photo")]
    public partial class Photo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

        public int ProductId { get; set; }

        public bool Featured { get; set; }

        public virtual Product Product { get; set; }

    }
}
