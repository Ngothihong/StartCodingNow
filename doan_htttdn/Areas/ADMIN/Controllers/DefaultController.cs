using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doan_htttdn.Areas.ADMIN.Controllers
{
    public class DefaultController : Controller
    {
        // GET: ADMIN/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}