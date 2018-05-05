using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moksh.PSAS.WebApp.Controllers
{
    public class RiskController : Controller
    {
        // GET: Risk
        [HttpGet]
        public ActionResult RiskIdentify()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RiskCategorize()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RiskAssign()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RiskAssess()
        {
            return View();
        }


    }
    }
