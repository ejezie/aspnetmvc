using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspmvc_learn.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            //string date = DateTime.Now.ToLongDateString();
            //return Ok(date);
        }
    }
}
