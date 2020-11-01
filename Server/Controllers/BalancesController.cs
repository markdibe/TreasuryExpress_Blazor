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
    public class BalancesController : ControllerBase
    {

        private readonly IUnitOfWork uow;
        public BalancesController(IUnitOfWork unit)
        {
            uow = unit;
        }

        // GET: api/<BalancesController>
        [HttpGet("{id}")]
        public IEnumerable<Balance> Get(int id)
        {
            return uow.BalanceService.GetListByAccount(id);
        }

        // GET api/<BalancesController>/5
        [HttpGet("{id}/{date}")]
        public Balance Get(int id, string date)
        {
            DateTime adate;
            DateTime.TryParse(date, out adate);
            return uow.BalanceService.GetFirstBy(id, adate);
        }


    }
}
