using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFinanceiro.Entity;
using SistemaFinanceiro.DAL.Repositories;


namespace SistemaFinanceiro.BLL
{
    public class ReceitaBusiness
    {
        public void Cadastrar(Receita r)
        {
            ReceitaRepositorio rep = new ReceitaRepositorio();
            rep.Insert(r);
        }

        public void Atualizar(Receita r)
        {
            ReceitaRepositorio rep = new ReceitaRepositorio();
            rep.Update(r);
        }

        public void Excluir(Receita r)
        {
            ReceitaRepositorio rep = new ReceitaRepositorio();
            rep.Delete(r);
        }

        public List<Receita> ConsultarTodos()
        {
            ReceitaRepositorio rep = new ReceitaRepositorio();
            return rep.FindAll();
        }

        public Receita ConsultarPorId(int id)
        {
            ReceitaRepositorio rep = new ReceitaRepositorio();
            return rep.FIndById(id);
        }

        
    }
}
