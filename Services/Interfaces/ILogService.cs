using SharedObjects.Common;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILogService
    {
        Task<List<VLog>> Log_get(LogViewModel model);
        Task<List<VLog>> Log_getall(LogViewModel model);
        Task<int> Log_count(LogViewModel model);


    }
}
