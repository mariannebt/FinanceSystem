using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SistemaFinanceiro.Entity;

namespace SistemaFinanceiro.DAL.Mappings
{
    public class ReceitaMap : EntityTypeConfiguration<Receita>
    {
        public ReceitaMap()
        {
            ToTable("Receita");

            HasKey(r => r.Id);

            Property(r => r.Id)
                .HasColumnName("IdReceita")
                .IsRequired();

            Property(r => r.Nome)
                .HasColumnName("NomeRec")
                .HasMaxLength(50)
                .IsRequired();

            Property(r => r.Valor)
                .HasColumnName("ValorReceita")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(r => r.Data)
                .HasColumnName("DataEntrada")
                .IsRequired();

            Property(r => r.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(150)
                .IsOptional();

            HasRequired(r => r.Conta)
                .WithMany(c => c.Receitas)
                .HasForeignKey(r => r.IdConta);
        }

    }
}
