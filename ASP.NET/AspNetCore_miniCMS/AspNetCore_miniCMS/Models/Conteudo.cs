using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Models
{
    public class Conteudo
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Pagina { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }

        public string Texto { get; set; }

        [StringLength(50)]
        public string Autor { get; set; }

        public DateTime Data { get; set; }
    }
}
