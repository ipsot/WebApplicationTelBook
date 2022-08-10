using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationTelBook.Model;
using WebApplicationTelBook.Model.Entities;

namespace WebApplicationTelBook.Controllers
{
    public class MansController : Controller
    {
        private DbManager db = DbManager.GetInstance();

        public ActionResult Index()
        {
            List<Man> mans = db.TableMans.GetAllMans();
            return View(mans);
        }
    }
}