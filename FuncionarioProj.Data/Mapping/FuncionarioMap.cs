using FuncionarioProj.Data.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioProj.Data.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("tb_Funcionario");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.NomeEmpresa)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(f => f.Setor)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(f => f.DataInicio)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(f => f.DataTermino)
               .IsRequired()
               .HasColumnType("datetime");

            builder.Property(f => f.Ativo)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
