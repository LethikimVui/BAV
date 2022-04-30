using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;

namespace BAV.Controllers
{
    [Authorize]
    public class BAVController : Controller
    {
        private readonly IBAVService bAVService;
        private ADODB.Recordset rs = new ADODB.Recordset();

        public BAVController(IBAVService bAVService)
        {
            this.bAVService = bAVService;
        }

        public async Task<IActionResult> Configuration()
        {
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            //DataTable dt = new DataTable();
            //JEMS_3.CR_Assemblies cr = new JEMS_3.CR_Assemblies();
            ////rs = cr.ListByCustomer("VNHCMM0MSSQLV1A", "JEMS", 6511, 14);
            //rs = cr.ListActive("VNHCMM0MSSQLV1A", "JEMS", 6511);
            //dataAdapter.Fill(dt, rs);
            //List<VJEMS> list = new List<VJEMS>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    VJEMS t = new VJEMS()
            //    {
            //        Customer = dt.Rows[i]["Customer"].ToString().Trim(),
            //        Number = dt.Rows[i]["Number"].ToString().Trim(),
            //        Revision = dt.Rows[i]["Revision"].ToString(),
            //        Family = dt.Rows[i]["Family"].ToString(),
            //        Assembly = dt.Rows[i]["Assembly"].ToString(),
            //    };
            //    list.Add(t);
            //}
            //ViewData["list"] = list;

            var model = new BAVViewModel();
            model.Model = null;
            model.Revision = null;
            var results = await bAVService.Configuration_getall(model);
            ViewData["data"] = results;
            return View();
        }
        public async Task<IActionResult> Configuration_add([FromBody] BAVViewModel model)
        {
            var results = await bAVService.Configuration_add(model);
            return Json(new { results = results });
        } 
        public async Task<IActionResult> Configuration_delete([FromBody] BAVViewModel model)
        {
            var results = await bAVService.Configuration_delete(model);
            return Json(new { results = results });
        }
        public async Task<IActionResult> Configuration_Get([FromBody] BAVViewModel model)
        {
            var results = await bAVService.Configuration_get(model);
            return PartialView(results);
        }
        public async Task<IActionResult> Configuration_getall([FromBody] BAVViewModel model)
        {
            var results = await bAVService.Configuration_getall(model);
            return PartialView(results);
        }
        public async Task<IActionResult> Configuration_count([FromBody] BAVViewModel model)
        {
            var count = await bAVService.Configuration_count(model);
            return Json(new { result = count });
        }
    }
}
