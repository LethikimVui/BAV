using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SharedObjects.Common;
using SharedObjects.StoredProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BAVController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public BAVController(ApplicationDbContext context)
        {
            this.context = context;

        }
        [HttpGet("test/{t}")]
        public List<AccessRole> Test(int t)
        {
            var results = context.AccessRole.Where(s => s.RoleId == t).ToList();
            return results;
        }
    
        [HttpPost("Configuration_get")]
        [Obsolete]
        public async Task<List<VConfiguration>> Configuration_getpagination([FromBody] BAVViewModel model)
        {
            var results = await context.Query<VConfiguration>().AsNoTracking().FromSql(SPBAV.Configuration_get, model.PageIndex, model.PageSize, model.Model, model.Revision, model.Accessory).ToListAsync();
            return results;
        }
        [HttpPost("Configuration_getall")]
        [Obsolete]
        public async Task<List<VConfiguration>> Configuration_get(BAVViewModel model)
        {
            var results = await context.Query<VConfiguration>().AsNoTracking().FromSql(SPBAV.Configuration_getall, model.Model, model.Revision, model.Accessory).ToListAsync();
            return results;
        }
        [HttpPost("Configuration_count")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<int> Configuration_count([FromBody] BAVViewModel model)
        {
            var output = new SqlParameter
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.Output
            };
            await context.Database.ExecuteSqlCommandAsync(SPBAV.Configuration_count, model.Model, model.Revision, model.Accessory, output);
            var result = (int)output.Value;
            return result;
        }
        [HttpPost("Configuration_add")]
        [Obsolete]
        public async Task<IActionResult> Configuration_add(BAVViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPBAV.Configuration_add, model.Model, model.Family, model.Revision, model.Accessory, model.Description, model.CreatedBy, model.CreatedName, model.CreatedEmail);
                return Ok(new ResponseResult(200, "Added Successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("Configuration_delete")]
        [Obsolete]
        public async Task<IActionResult> Configuration_delete(BAVViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPBAV.Configuration_delete, model.Id, model.CreatedBy, model.CreatedName, model.CreatedEmail);
                return Ok(new ResponseResult(200, "deleted successfully"));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}
