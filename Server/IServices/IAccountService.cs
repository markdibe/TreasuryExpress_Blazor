using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.IServices
{
    public interface IAccountService
    {
        Account Add(Account account);
        Account Update(Account editedAccount);
        void Delete(int AccountId);

        Account GetByIBAN(string IBAN);
        Account GetById(int id);
        List<Account> Get();
        Account GetByLocalNumber(string localNumber);
    }
}
