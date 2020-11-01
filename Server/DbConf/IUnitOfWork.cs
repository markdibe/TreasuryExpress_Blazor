using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Server.IServices;

namespace TreasuryExpress.Server.DbConf
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountService AccountService { get; }
        ILogService LogService { get; }
        ITransactionService TransactionService { get; }
        IBalanceService BalanceService { get; }

    }
}
