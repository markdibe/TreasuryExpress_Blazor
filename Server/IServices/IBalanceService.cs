using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.IServices
{
    public interface IBalanceService
    {
        Balance Add(Balance balance);
        Balance Update(Balance balance);
        Balance Delete(int AccountId, DateTime BalanceDate);
        Balance GetFirstBy(int AccountId,DateTime BalanceDate);
        List<Balance> Get(int page = 1, int length = 10);
        List<Balance> Get();
        List<Balance> GetListBy(int AccountId, DateTime startDate);
        List<Balance> GetListByAccount(int AccountId);
        bool BalanceExist(int accountId, DateTime date);
        List<Balance> GetEffectedBalances(int accountId, DateTime date);

        void UpdateBalanceList(List<Balance> Balances);
        
    }
}
