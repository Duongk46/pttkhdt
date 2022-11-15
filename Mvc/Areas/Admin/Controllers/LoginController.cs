using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.CallRecords;
using Mvc.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserBusiness _userBusiness;
        public LoginController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Index(string username,string password)
        {
            try
            {
                var check = _userBusiness.CheckLogin(username,password);
                if (check == 1)
                {
                    HttpContext.Session.SetString("User", username);
                    return Redirect("/Admin/Home");
                }
                else
                {
                    if (check == 2)
                    {
                        ViewBag.Message = "Tài khoản không tồn tại";
                    }
                    else
                    {
                        ViewBag.Message = "Sai mật khẩu";
                    }
                }
                
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Đăng nhập không thành công";
            }
            return View();

        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Admin/Login");
        }
    }
}
