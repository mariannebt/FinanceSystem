using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SistemaFinanceiro.Entity;

namespace SistemaFinanceiro.DAL.Mappings
{
    public class DespesaMap : EntityTypeConfiguration<Despesa>
    {
        public DespesaMap()
        {
            ToTable("Despesa");

            HasKey(d => d.Id);

            Property(d => d.Id)
                .HasColumnName("IdDespesa")
                .IsRequired();

            Property(d => d.Nome)
               .HasColumnName("NomeDesp")
               .HasMaxLength(50)
               .IsRequired();

            Property(d => d.Valor)
                .HasColumnName("ValorDespesa")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(d => d.Data)
                .HasColumnName("DataPagamento")
                .IsRequired();

            Property(d => d.DataVencimento)
              .HasColumnName("DataVencimento")
              .IsRequired();

            Property(d => d.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(150)
                .IsOptional();

            HasRequired(d => d.Conta)
                .WithMany(c => c.Despesas)
                .HasForeignKey(d => d.IdConta);


        }


    }
}
