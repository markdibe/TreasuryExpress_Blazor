using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TreasuryExpress.Server.DbConf;
using TreasuryExpress.Server.IServices;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.Services
{
    public class BalanceService : IBalanceService
    {
        private readonly ApplicationDbContext _context;
        private LogService log;
        public BalanceService(ApplicationDbContext context)
        {
            _context = context;
            log = new LogService(_context);
        }
        public Balance Add(Balance balance)
        {
            try
            {
                _context.Balances.Add(balance);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                log.Add(e);
            }
            return balance;
        }

        public Balance Delete(int AccountId , DateTime BalanceDate)
        {
            Balance balance = GetFirstBy(AccountId,BalanceDate);
            try
            {
                _context.Balances.Remove(balance);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                log.Add(e);
            }
            return balance;
        }

        public List<Balance> Get(int page = 1, int length = 10)
        {
            List<Balance> Balances = _context.Balances
                .AsNoTracking()
                .Skip((page - 1) * 10)
                .Take(page * length)
                .ToList();
            return Balances;
        }

        public List<Balance> Get()
        {
            return _context.Balances
                .AsNoTracking()
                .ToList();
        }

        public List<Balance> GetListBy(int AccountId, DateTime startDate= default)
        {
            return _context.Balances
                .AsNoTracking()
                .Where(x => x.AccountId == AccountId && x.BalanceDate.Date >= startDate.Date)
                .ToList();
        }

        public List<Balance> GetListByAccount(int AccountId)
        {
            return _context.Balances
                .AsNoTracking()
                .Where(x => x.AccountId == AccountId)
                .ToList();
        }

        public Balance GetFirstBy(int AccountId, DateTime BalanceDate)
        {
            return _context.Balances
                .AsNoTracking()
                .FirstOrDefault(x => x.BalanceDate.Date == BalanceDate.Date && x.AccountId == AccountId);
        }

        public Balance Update(Balance balance)
        {
            try
            {
                _context.Balances.Update(balance);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                log.Add(e);
            }
            return balance;
        }

        public bool BalanceExist(int accountId, DateTime date)
        {
            return _context.Balances.Any(x => x.AccountId == accountId && x.BalanceDate.Date == date.Date);
        }

        public List<Balance> GetEffectedBalances(int accountId, DateTime date)
        {
           return _context.Balances
                .Where(x => x.AccountId == accountId 
                && x.BalanceDate.Date <= date.Date)
                .ToList();
        }

        public void UpdateBalanceList(List<Balance> balances)
        {
            try
            {
                _context.UpdateRange(balances);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                log.Add(e);
            }
        }
    }
}
