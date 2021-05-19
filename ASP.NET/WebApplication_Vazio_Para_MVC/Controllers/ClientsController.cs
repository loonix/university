using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Vazio_Para_MVC.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
