using AdmCondominio.Business.Entities;
using AdmCondominio.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace AdmCondominio.Data.Context
{
    public class AdmCondominioDbContext : DbContext
    {
        public DbSet<Condominio>? Condominios { get; set; }
        public DbSet<Bloco>? Blocos { get; set; }
        public DbSet<Apartamento>? Apartamentos { get; set; }
        public DbSet<Morador>? Moradores { get; set; }
        public AdmCondominioDbContext (DbContextOptions<AdmCondominioDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CondominioConfiguration());
            modelBuilder.ApplyConfiguration(new BlocoConfiguration());
            modelBuilder.ApplyConfiguration(new ApartamentoConfiguration());
            modelBuilder.ApplyConfiguration(new MoradorConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
