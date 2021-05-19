﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Vazio_Para_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre() 
        {
            return View(); 
        }

        public string Mensagem()
        {
            return $"A data de hoje e: {DateTime.Now}";
        }
    }
}