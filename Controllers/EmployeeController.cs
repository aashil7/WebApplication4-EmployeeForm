using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Repository;
using WebApplication4.ViewModel;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Common objRepo = new Common();

            var appRefStatus = objRepo.GetAppRefData(1800);

            var empVM = new EmployeeAddEditViewModel
            {
                StatusList = appRefStatus
            };

            return View(empVM);
        }
    }
}