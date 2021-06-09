using System;
using System.Collections.Generic;

#nullable disable

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataRegisto { get; set; }
    }
}
