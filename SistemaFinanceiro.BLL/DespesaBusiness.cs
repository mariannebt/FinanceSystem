using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFinanceiro.Entity;
using SistemaFinanceiro.DAL.Repositories;



namespace SistemaFinanceiro.BLL
{
    public class DespesaBusiness
    {
        public void Cadastrar(Despesa d)
        {
            DespesaRepositorio rep = new DespesaRepositorio();
            rep.Insert(d);
        }

        public void Atualizar(Despesa d)
        {
            DespesaRepositorio rep = new DespesaRepositorio();
            rep.Update(d);
        }

        public void Excluir(Despesa d)
        {
            DespesaRepositorio rep = new DespesaRepositorio();
            rep.Delete(d);
        }

        public List<Despesa> ConsultarTodos()
        {
            DespesaRepositorio rep = new DespesaRepositorio();
            return rep.FindAll();
        }

        public Despesa ConsultarPorId(int id)
        {
            DespesaRepositorio rep = new DespesaRepositorio();
            return rep.FIndById(id);
        }
    }
}
