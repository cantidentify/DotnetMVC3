using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotnetMVC3.Models;

namespace DotnetMVC3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(DotnetMVC3.Models.UserDataModel userModel)
        {
            IList<UserDataModel> userlist = new List<UserDataModel>() {
                new UserDataModel () { UserId  = 1 , UserName = "john" , Password = "1234"},
                new UserDataModel () { UserId  = 2 , UserName = "jame" , Password = "1234"},
                new UserDataModel () { UserId  = 3 , UserName = "jasmin" , Password = "1234"},
                new UserDataModel () { UserId  = 4 , UserName = "joe" , Password = "1234"}
            };
            var filterdResult = (from user in userlist
                                 where user.UserName == userModel.UserName && user.Password == userModel.Password
                                 select user).ToList();
            if (filterdResult.Count == 0)
            {
                userModel.LoginErrorMessage = "Wrong username or password";
                return View("index", userModel);
            }
            else
            {
                userModel.LoginErrorMessage = "Success Login";
                return RedirectToAction("Index", "Home");
            }

        }
    }
}