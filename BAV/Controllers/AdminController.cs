using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SharedObjects.Extensions;

namespace BAV.Controllers
{
    [Authorize(Roles = "SYSTEM ADMIN")]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        public string GetDisplayNameFromSamAccountName(string samAccountName)
        {
            using (var principalContext = new PrincipalContext(ContextType.Domain))
            {
                try
                {
                    var userPrincipal = UserPrincipal.FindByIdentity(principalContext, samAccountName);
                    if (userPrincipal != null)
                    {
                        return userPrincipal.DisplayName;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }

            }
        }
        static string EmailAddress(string userName)
        {
            var EmailAddress = "";
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                var userPrincipal = UserPrincipal.FindByIdentity(context, userName);
                EmailAddress = userPrincipal.EmailAddress;

            }
            return EmailAddress;
        }
        static string DisplayName(string userName)
        {
            var DisplayName = "";
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                var userPrincipal = UserPrincipal.FindByIdentity(context, userName);
                DisplayName = userPrincipal.DisplayName;

            }
            return DisplayName;
        }
        public async Task<IActionResult> Get()
        {
            var NtLogin = User.GetSpecificClaim("Ntlogin");
            var userRoles = await adminService.Access_UserRole_get();
            var roles = await adminService.Access_Role_get();
            ViewData["roles"] = roles;
            // ViewData["customers"] = await commonService.Customer_get(NtLogin);
            return View(userRoles);
        }
        public async Task<IActionResult> Access_UserRole_insert([FromBody] UserRoleViewModel model)
        {
            model.UserName = DisplayName(model.Ntlogin);
            model.UserEmail = EmailAddress(model.Ntlogin);
            var result = await adminService.Access_UserRole_insert(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Access_UserRole_update([FromBody] UserRoleViewModel model)
        {
           
            var result = await adminService.Access_UserRole_update(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Access_UserRole_delete([FromBody] UserRoleViewModel model)
        {
            var result = await adminService.Access_UserRole_delete(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Access_UserRole_Get_By_Id(int id)
        {
            var result = await adminService.Access_UserRole_Get_By_Id(id);
            return Json(new { results = result });
        }

    }
}
