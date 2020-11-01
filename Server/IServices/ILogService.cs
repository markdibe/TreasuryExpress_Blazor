using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.IServices
{
    public interface ILogService
    {
        Log Add(Log log);
    }
}
