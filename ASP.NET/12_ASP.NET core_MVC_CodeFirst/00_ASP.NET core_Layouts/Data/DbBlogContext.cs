using _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ASP.NET_core_Layouts_CSS_e_Bootstrap.Data
{
    public class DbBlogContext: DbContext
    {
        public IConfiguration Configuration { get; }
        public DbBlogContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("BlogsConnection"));

            }
        }

    }
}
