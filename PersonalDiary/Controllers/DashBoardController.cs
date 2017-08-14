using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalDiary.Filters;

namespace PersonalDiary.Controllers
{
    public class DashBoardController:Controller
    {
        //
        // GET: /DashBoard/
        [SessionAuthentication]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

    }
}
