using D1.ApplicationContacts.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D1.ApplicationContacts.Data.Mappings
{
    class RedeSocialMapping : IEntityTypeConfiguration<RedeSocial>
    {
        public void Configure(EntityTypeBuilder<RedeSocial> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Link)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(r => r.TipoRedeSocial)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.ToTable("RedesSociais");

        }
    }
}
