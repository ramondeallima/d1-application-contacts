using D1.ApplicationContacts.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace D1.ApplicationContacts.Data.Context
{
    class ApplicationContactsDbContext : DbContext
    {
        public ApplicationContactsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<RedeSocial> RedesSociais { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContactsDbContext).Assembly);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
