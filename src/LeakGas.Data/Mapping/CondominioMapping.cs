using LeakGas.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeakGas.Data.Mapping
{
    public class CondominioMapping : IEntityTypeConfiguration<Condominio>
    {
        public void Configure(EntityTypeBuilder<Condominio> builder)
        {
            builder.HasMany(c => c.UsuariosCondominios)
                    .WithOne(uc => uc.Condominio)
                    .HasForeignKey(uc => uc.IdCondominio);
        }
    }

}
