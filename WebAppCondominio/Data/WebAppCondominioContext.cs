using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCondominio.Models;

namespace WebAppCondominio.Data
{
    public class WebAppCondominioContext : DbContext
    {
        public WebAppCondominioContext (DbContextOptions<WebAppCondominioContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCondominio.Models.Condominio> Condominio { get; set; }

        public DbSet<WebAppCondominio.Models.Familia> Familia { get; set; }

        public DbSet<WebAppCondominio.Models.Morador> Morador { get; set; }
    }
}
