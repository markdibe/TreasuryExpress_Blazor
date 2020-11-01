using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TreasuryExpress.Server.DbConf;
using TreasuryExpress.Server.IServices;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;
        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Account Add(Account account)
        {
            try
            {
                bool isExisted = _context.Accounts.Any(x => x.IBAN.ToLower().Trim().Equals(account.IBAN.ToLower().Trim()));
                if (!isExisted)
                {
                    _context.Accounts.Add(account);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            return account;
        }

        public void Delete(int id)
        {
            try
            {
                Account selectedAccount = GetById(id);
                _context.Accounts.Remove(selectedAccount);
                _context.SaveChanges();
                
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public List<Account> Get()
        {
            return _context.Accounts.ToList();
        }

        public Account GetByIBAN(string IBAN)
        {
            return _context.Accounts
                .FirstOrDefault(x => x.IBAN.ToLower().Trim().Equals(IBAN.ToLower().Trim()));
        }

        public Account GetById(int id)
        {
            Account account = _context.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == id);
            return account;
        }

        public Account GetByLocalNumber(string localNumber)
        {
            localNumber = localNumber.Trim().ToLower();
            return _context.Accounts
                .FirstOrDefault(x => x.LocalAccountNumber.ToLower().Trim().Equals(localNumber));
        }

        public Account Update(Account EditedAccount)
        {
            //Account dbAccount = GetById(EditedAccount.AccountId);
            //if (dbAccount != null)
            //{
            //    dbAccount.BankName = EditedAccount.BankName;
            //    dbAccount.Currency = EditedAccount.Currency;
            //    dbAccount.IBAN = EditedAccount.IBAN;
            //    dbAccount.LocalAccountNumber = EditedAccount.LocalAccountNumber;
            //    _context.SaveChanges();
            //}
            _context.Accounts.Update(EditedAccount);
            _context.SaveChanges();
            return EditedAccount;
        }
    }
}
