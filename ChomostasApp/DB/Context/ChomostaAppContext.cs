using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ChomostasApp.DB.Context
{
    public partial class ChomostaAppContext : DbContext
    {
        /*
        private IConfiguration configuration;
        public ChomostaAppContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        */

        public ChomostaAppContext()
        {

        }

        public ChomostaAppContext(DbContextOptions<ChomostaAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TablaPrueba> TablaPrueba { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:chomostadb.database.windows.net,1433;Initial Catalog=ChomostaApp;Persist Security Info=False;User ID=chomostaadmin;Password=chomosta_123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TablaPrueba>(entity =>
            {
                entity.HasKey(e => e.JefitaId);

                entity.Property(e => e.JefitaId)
                    .HasColumnName("JefitaID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Jefita)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
