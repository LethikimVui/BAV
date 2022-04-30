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
    public interface IBAVService
    {
        Task<int> Configuration_count(BAVViewModel model);
        Task<List<VConfiguration>> Configuration_get(BAVViewModel model);
        Task<List<VConfiguration>> Configuration_getall(BAVViewModel model);
        Task<ResponseResult> Configuration_add(BAVViewModel model);
        Task<ResponseResult> Configuration_delete(BAVViewModel model);


    }
}
