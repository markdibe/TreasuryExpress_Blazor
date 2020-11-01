using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TreasuryExpress.Server.DbConf;
using TreasuryExpress.Server.IServices;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ApplicationDbContext _context;
        private LogService log;
        public TransactionService(ApplicationDbContext context)
        {
            _context = context;
            log = new LogService(_context);
        }
        public Transaction Add(Transaction transaction)
        {
            try
            {
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                log.Add(e);
            }
            return transaction;
        }

        public Transaction Delete(int TransactionId)
        {
            Transaction transaction = GetById(TransactionId);
            try
            {
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                log.Add(e);
            }
            return transaction;
        }

        public List<Transaction> GetByAccount(int AccountId)
        {
            return _context.Transactions
                .AsNoTracking()
                .Where(x => x.AccountId == AccountId).ToList();

        }

        public Transaction GetById(int TransactionId)
        {
            return _context.Transactions
                .AsNoTracking()
                .FirstOrDefault(x => x.TransactionId == TransactionId);
        }

        public Transaction Update(Transaction transaction)
        {
            try
            {
                _context.Transactions.Update(transaction);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                log.Add(e);
            }
            return transaction;
        }
    }
}
