using Moksh.PSAS.Bussiness.Managers;
using Moksh.PSAS.Common;
using System.Web.Mvc;

namespace Moksh.PSAS.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet] //read only, and gets from the server 
        public ActionResult Login()

        {
            return View();
        }

        [HttpPost] //post for inserting, put for updating
        public ActionResult Login(LoginModel userLoginData)
        {


            if (ModelState.IsValid)
            {
                PeopleManager peopleObj = new PeopleManager();
                int userID = peopleObj.CheckNGetUserID(userLoginData.Email, userLoginData.Password);
                ViewData["PeopleID"] = userID;
                Session["PeopleID"] = userID;
                
                return RedirectToAction("RiskIdentify", "Risk"); // redirect to RiskRegister page, in Risk folder
               
            }
            else
            {
                return View();
            }


        }



    }
}
