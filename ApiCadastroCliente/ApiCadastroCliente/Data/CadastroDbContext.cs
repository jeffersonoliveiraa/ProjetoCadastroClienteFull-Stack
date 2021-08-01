using ApiCadastroCliente.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCadastroCliente.Data
{
    public class CadastroDbContext : DbContext
    {
        public CadastroDbContext(DbContextOptions<CadastroDbContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("cliente");
            modelBuilder.Entity<Perfil>().ToTable("perfil");
            modelBuilder.Entity<Usuario>()
            .HasOne<Perfil>(s => s.Perfil)
            .WithMany(g => g.Usuarios)
            .HasForeignKey(s => s.IDPerfil);
        }
    }

}
