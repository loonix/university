using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Data
{
    public class DbInitializer
    {
        public static void Initialize(DbBlogContext context)
        {
            // Classe para inicializar a Base dados
            context.Database.EnsureCreated();
        }
    }
}
