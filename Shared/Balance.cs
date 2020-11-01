using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreasuryExpress.Shared
{
    public class Balance
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BalanceDate { get; set; }

        [Required]
        [DataType(DataType.CreditCard)]
        public string AccountNumber { get; set; }

        public double BalanceAmount { get; set; }

        
        public Account Account { get; set; }
        
        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }
    }
}
