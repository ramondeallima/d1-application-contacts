using D1.ApplicationContacts.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D1.ApplicationContacts.Data.Mappings
{
    class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Numero)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(t => t.TipoTelefone)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.ToTable("Telefones");

        }
    }
}
