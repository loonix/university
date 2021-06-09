using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _08_Forms.Models;

namespace _08_Forms.Data
{
    public class _08_FormsContext : DbContext
    {
        public _08_FormsContext (DbContextOptions<_08_FormsContext> options)
            : base(options)
        {
        }

        public DbSet<_08_Forms.Models.Cliente> Cliente { get; set; }
    }
}
