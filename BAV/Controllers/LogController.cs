using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects.ViewModels;

namespace BAV.Controllers
{
    [Authorize]
    public class LogController : Controller
    {
        private readonly ILogService logService;

        public LogController(ILogService logService)
        {
            this.logService = logService;
        }
        public async Task<IActionResult> Get()
        {
            //var results = await logService.Log_get();
            return View();
        }
        public async Task<IActionResult> Log_count([FromBody] LogViewModel model)
        {
            var count = await logService.Log_count(model);
            return Json(new { result = count });
        }
        public async Task<IActionResult> Log_get([FromBody] LogViewModel model)
        {
            var results = await logService.Log_get(model);
            return PartialView(results);
        } 
        public async Task<IActionResult> Log_getall([FromBody] LogViewModel model)
        {
            var results = await logService.Log_getall(model);
            return Json(new { result = results });
        }



    }
}
