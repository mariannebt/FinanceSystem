using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SistemaFinanceiro.Entity;

namespace SistemaFinanceiro.DAL.Mappings
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            ToTable("Conta");

            HasKey(c => c.IdConta);

            Property(c => c.IdConta)
                .HasColumnName("IdConta")
                .IsRequired();

            Property(c => c.Saldo)
                .HasColumnName("Saldo")
                .HasPrecision(18, 2)
                .IsOptional();

            HasRequired(c => c.Usuario)
                .WithMany(u => u.Contas)
                .HasForeignKey(c => c.IdUsuario);
        }

    }
}
