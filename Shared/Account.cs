using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TreasuryExpress.Shared.CustomValidation;

namespace TreasuryExpress.Shared
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        [DataType(DataType.CreditCard)]
        public string LocalAccountNumber { get; set; }

        [ValidIBAN]
        [Required]
        public string IBAN { get; set; }

        [Required]
        [StringLength(100)]
        public string BankName { get; set; }

        [Required]
        public string Currency { get; set; }

        
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Balance> Balances { get; set; }

    }
}
