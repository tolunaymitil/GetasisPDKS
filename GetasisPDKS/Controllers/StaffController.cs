using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class StaffController : Controller
    {
        StaffManager sm = new StaffManager(new EfStaffRepository());
        public IActionResult Index()
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
