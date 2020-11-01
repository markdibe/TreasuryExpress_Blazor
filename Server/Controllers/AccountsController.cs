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

    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        public AccountsController(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }

        // GET: api/<AccountsController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return uow.AccountService.Get();
        }

        // GET api/<AccountsController>/5
        [HttpGet("{id}")]
        public Account Get(int id)
        {
            return uow.AccountService.GetById(id);
        }

        // POST api/<AccountsController>
        [HttpPost]
        public Account Post([FromBody] Account account)
        {
            if (ModelState.IsValid)
            {
                var result = uow.AccountService.Add(account);
                if (account.AccountId != default)
                {
                    uow.BalanceService.Add(new Balance
                    {
                        AccountId = result.AccountId,
                        AccountNumber = result.LocalAccountNumber,
                        BalanceAmount = 0,
                        BalanceDate = DateTime.Now
                    });
                }
                account = result;
            }
            return account;
        }

        // PUT api/<AccountsController>/5
        [HttpPut("{id}")]
        public Account Put(int id, [FromBody] Account Updatedaccount)
        {
            if (id == Updatedaccount.AccountId && ModelState.IsValid && id != default)
            {
                Updatedaccount = uow.AccountService.Update(Updatedaccount);
            }
            return Updatedaccount;
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id != default)
            {
                uow.AccountService.Delete(id);
            }
        }
    }
}
