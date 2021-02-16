using D1.ApplicationContacts.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D1.ApplicationContacts.Data.Mappings
{
    class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Cep)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.TipoEndereco)
                .HasColumnType("varchar(10)");

            builder.ToTable("Enderecos");

        }
    }
}
