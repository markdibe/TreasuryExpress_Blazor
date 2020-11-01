using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Server.DbConf;
using TreasuryExpress.Server.IServices;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.Services
{
    public class LogService : ILogService
    {
        private readonly ApplicationDbContext _context; 
        public LogService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Log Add(Log log)
        {
            try
            {
                _context.Logs.Add(log);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                throw (e);
            }
            return log;
        }

        public Log Add(Exception e)
        {
            Log log = new Log { LogMessage = e.Message };
            _context.Logs.Add(log);
            _context.SaveChanges();
            return log;
        }
    }
}
