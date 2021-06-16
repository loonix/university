using _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Data
{
    public class DbInitializer
    {
        public static void Initialize(DbConteudoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Conteudo.Any())
            {
                return; // DB has been seeded
            }
            var conteudos = new Conteudo[]
            {
             new Conteudo{Autor="Daniel",Pagina="Home",Titulo="<h1>Home</h1>", Data=DateTime.Parse("2005-09-01"), Texto="Ola"},
             new Conteudo{Autor="Rodrigo",Pagina="Home",Titulo="<h1>Home</h1>", Data=DateTime.Parse("2005-09-02"), Texto="Sou eu!"},
            };
            foreach (Conteudo s in conteudos)
            {
                context.Conteudo.Add(s);
            }
            context.SaveChanges();

        }
    }
}
