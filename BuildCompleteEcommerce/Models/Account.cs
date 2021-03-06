using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildCompleteEcommerce.Models
{
    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
            RoleAccounts = new HashSet<RoleAccount>();
            Invoices = new HashSet<Invoice>();
        }
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
