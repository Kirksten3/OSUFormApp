using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSU_Form_Application.Controllers
{
    public class FormController : Controller
    {
        //
        // GET: /Form/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
	}
}