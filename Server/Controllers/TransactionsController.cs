using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreasuryExpress.Server.DbConf;
using TreasuryExpress.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TreasuryExpress.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        public TransactionsController(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }
        // GET: api/<TransactionsController>
        [HttpGet("{transactionId:int}/{transactionDate}")]
        public IEnumerable<Transaction> Get(int transactionId, string transactionDate)
        {
            DateTime selectedDate; DateTime.TryParse(transactionDate, out selectedDate);
            return uow.TransactionService
                .GetByAccount(transactionId)
                .Where(x => x.TransactionDate >= selectedDate)
                .ToList();
        }

        // GET api/<TransactionsController>/5
        [HttpGet("{id}")]
        public Transaction Get(int id)
        {
            return uow.TransactionService.GetById(id);
        }

        // POST api/<TransactionsController>
        [HttpPost]
        public Transaction Post([FromBody] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                transaction = uow.TransactionService.Add(transaction);
                ValidateEffectedBalances(transaction);
            }
            return transaction;
        }


        private void ValidateEffectedBalances(Transaction transaction)
        {
            DateTime transactionDateTime = transaction.TransactionDate;
            bool isBalanceExists = uow.BalanceService.BalanceExist(transaction.AccountId, transactionDateTime);
            if (!isBalanceExists)
            {
                Balance LatestBalance = uow.BalanceService.GetEffectedBalances(transaction.AccountId, transactionDateTime).OrderByDescending(x => x.BalanceDate).FirstOrDefault();
                Balance newBalance = new Balance
                {
                    BalanceDate = transaction.TransactionDate,
                    AccountId = transaction.AccountId,
                    BalanceAmount = LatestBalance.BalanceAmount,
                    AccountNumber = LatestBalance.AccountNumber
                };
                uow.BalanceService.Add(newBalance);
            }
           
                List<Balance> balanceList = uow.BalanceService.GetEffectedBalances(transaction.AccountId, transactionDateTime);
                balanceList.ForEach((b) => b.BalanceAmount += transaction.TransactionAmount);
                uow.BalanceService.UpdateBalanceList(balanceList);    
        }


        // PUT api/<TransactionsController>/5
        [HttpPut("{id}")]
        public Transaction Put(int id, [FromBody] Transaction transaction)
        {
            if(transaction.TransactionId == id)
            {
                transaction = uow.TransactionService.Update(transaction);
                ValidateEffectedBalances(transaction);
            }
            return transaction;
        }

        // DELETE api/<TransactionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Transaction transaction = uow.TransactionService.GetById(id);
            Transaction tr = transaction;
            tr.TransactionId = 0;
            tr.TransactionAmount = -transaction.TransactionAmount;
            uow.TransactionService.Add(tr);
        }

        
    }
}
