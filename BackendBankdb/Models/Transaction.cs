using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendBankdb.Models
{
    public partial class Transaction
    {
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string IBAN { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime TimeStamp { get; set; }
        public long AccountId { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("Transaction")]
        public virtual Account Account { get; set; }
    }
}