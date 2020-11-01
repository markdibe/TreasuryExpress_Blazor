using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreasuryExpress.Shared
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public double TransactionAmount { get; set; }

        public DateTime TransactionDate { get; set; }
        public Account Account { get; set; }

        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }


    }
}
