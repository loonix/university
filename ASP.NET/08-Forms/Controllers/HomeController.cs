using _08_Forms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_Forms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conteudo()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Form_1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form_1(string utilizador, string password, string lembrar)
        {
            //Cliente cliente = new Cliente();
            //cliente.Nome = utilizador;
            //cliente.Password = password;
            //ou ..
            Cliente cliente = new Cliente { Nome = utilizador, Password = password };
            // Codigo para usar as variaveis 'utilizador', 'password' e 'lembrar'
            // return View("Index");
            return View("Dados_recebidos", cliente);
        }

        [HttpPost]
        public ActionResult Form_2(IFormCollection formCollection)
        {
            string nome = formCollection["Nome"];
            string apelido = formCollection["Apelido"];
            string email = formCollection["Email"];
            Cliente cliente = new Cliente { Nome = nome, Apelido = apelido, Email = email };
            // Codigo para usar as variaveis 'utilizador', 'password' e 'lembrar'
            // return View("Index");
            return View("Dados_recebidos", cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form_3(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("Dados_recebidos", cliente);
            }
            return View();
        }



        public IActionResult Form_2()
        {
            return View();
        }
        public IActionResult Form_3()
        {
            return View();
        }

    }
}
