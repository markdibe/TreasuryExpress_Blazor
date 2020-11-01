using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.IServices
{
    public interface ITransactionService
    {
        Transaction Add(Transaction transaction);
        Transaction Update(Transaction transaction);
        
        Transaction Delete(int TransactionId);

        Transaction GetById(int TransactionId);

        List<Transaction> GetByAccount(int AccountId);


    }
}
