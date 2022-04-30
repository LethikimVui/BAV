using API.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SharedObjects.Common;
using SharedObjects.StoredProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LogController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost("Log_get")]
        [Obsolete]
        public async Task<List<VLog>> Log_get([FromBody] LogViewModel model)
        {
            var results = await context.Query<VLog>().AsNoTracking().FromSql(SPLog.Log_get, model.PageIndex, model.PageSize, model.Model, model.DateFrom, model.DateTo).ToListAsync();
            return results;
        }
        [HttpPost("Log_getall")]
        [Obsolete]
        public async Task<List<VLog>> Log_getall([FromBody] LogViewModel model)
        {
            var results = await context.Query<VLog>().AsNoTracking().FromSql(SPLog.Log_getall, model.Model, model.DateFrom, model.DateTo).ToListAsync();
            return results;
        }
        [HttpPost("Log_count")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<int> Configuration_count([FromBody] LogViewModel model)
        {
            var output = new SqlParameter
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.Output
            };
            await context.Database.ExecuteSqlCommandAsync(SPLog.Log_count,model.Model, model.DateFrom, model.DateTo, output);
            var result = (int)output.Value;
            return result;
        }
    }
}
