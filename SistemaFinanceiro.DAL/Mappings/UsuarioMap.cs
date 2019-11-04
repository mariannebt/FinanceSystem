using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SistemaFinanceiro.Entity;

namespace SistemaFinanceiro.DAL.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(u => u.Cpf);

            Property(u => u.Cpf)
                .HasColumnName("CPF")
                .IsRequired();

            Property(u => u.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(u => u.Email)
                .HasColumnName("Email")
                .HasMaxLength(80)
                .IsRequired();

            Property(u => u.Senha)
                .HasColumnName("Senha")
                .IsRequired();

            Property(u => u.DataCadastro)
               .HasColumnName("DataCadastro")
               .IsRequired();
        }

    }
}
