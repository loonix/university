using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
