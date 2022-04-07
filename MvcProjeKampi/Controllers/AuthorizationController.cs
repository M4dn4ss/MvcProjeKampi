using BusinessLayerr.Concrete;
using DataAccessLayerr.EntityFramework;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = adminManager.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminManager.AdminAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalue = adminManager.GetByID(id);
            return View(adminvalue);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adminManager.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}