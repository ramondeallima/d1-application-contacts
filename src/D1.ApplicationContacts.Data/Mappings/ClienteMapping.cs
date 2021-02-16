using D1.ApplicationContacts.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D1.ApplicationContacts.Data.Mappings
{
    class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.RedeSocial)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(c => c.Rg)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("varchar(20)");

            // 1 : N => Cliente : Telefones

            builder.HasMany(c => c.Telefones)
                .WithOne(t => t.Cliente)
                .HasForeignKey(t => t.ClienteId);

            // 1 : N => Cliente : Redes Sociais

            builder.HasMany(c => c.RedesSociais)
                .WithOne(r => r.Cliente)
                .HasForeignKey(r => r.ClienteId);

            builder.ToTable("Clientes");
        }
    }
}
