using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{

    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SingUp()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SingUp(string login, string password, string passwordrepeat)
        {
            if (!password.Equals(passwordrepeat))
            {
                ViewBag.Message = "Passwords dont match";
                return View();
            }

            UserOperations uo = new UserOperations();
            uo.AddUser(new MUser(login,password, "student"));
            ViewBag.Message = "Succesfully registred";
            return View();   
        }

        public ActionResult StudentTimetable()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string login, string password)
        {
            UserOperations op = new UserOperations();
            var listUsers = op.GetUsers();
            string role = "none";
            foreach (MUser u in  listUsers)
            {
                if (u.Password.Equals(password) && u.Name.Equals(login))
                {
                    role = u.Role;
                }
            }

            if (role.Equals("student"))
                return Redirect("studenttimetable");
            else
            {
                ViewBag.Message = "Incorrect login or password, try again";
                return View();
            }
                
        }
    }
}