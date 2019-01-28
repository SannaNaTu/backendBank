using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendBankdb.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            Account = new HashSet<Account>();
        }

        public long Id { get; set; }
        [Required]
        [StringLength(20)]
        public string IBAN { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime TimeStamp { get; set; }

        [InverseProperty("CustomerNavigation")]
        public virtual ICollection<Account> Account { get; set; }
    }
}