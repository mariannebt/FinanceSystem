using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using SistemaFinanceiro.Entity;
using SistemaFinanceiro.DAL.Mappings;



namespace SistemaFinanceiro.DAL.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base(ConfigurationManager.ConnectionStrings["sistemafinanceiro"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ContaMap());
            modelBuilder.Configurations.Add(new ReceitaMap());
            modelBuilder.Configurations.Add(new DespesaMap());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
    }
}
