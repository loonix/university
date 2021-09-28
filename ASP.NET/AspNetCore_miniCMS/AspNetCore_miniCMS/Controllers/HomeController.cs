using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_AspNetCore_MVC_base_bootstrap.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            // recuperar da BD miniCMS da tabela Conteudo, o registo cujo campo Pagina = "Home"
            var paginaHome = _context.Conteudos.FirstOrDefault(m => m.Pagina == "Home");
            if (paginaHome == null)
            {
                return NotFound();
            }
            return View(paginaHome);
        }

       
    }
}
