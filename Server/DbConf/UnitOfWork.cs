using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Server.IServices;
using TreasuryExpress.Server.Services;

namespace TreasuryExpress.Server.DbConf
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        #region private interface instances 
        private IAccountService accountService;
        private ILogService logService;
        private IBalanceService balanceService;
        private ITransactionService transactionService;
        #endregion

        public IAccountService AccountService { get { return accountService ??= new AccountService(_context); } }
        public ILogService LogService { get { return logService ??= new LogService(_context); } }
        public IBalanceService BalanceService { get { return balanceService ??= new BalanceService(_context); } }
        public ITransactionService TransactionService { get { return transactionService ??= new TransactionService(_context); } }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
