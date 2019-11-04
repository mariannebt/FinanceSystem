using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFinanceiro.Entity;
using SistemaFinanceiro.DAL.Repositories;


namespace SistemaFinanceiro.BLL
{
    public class ContaBusiness
    {
        public void Cadastrar(Conta c)
        {
            c.Saldo = 0;
            ContaRepositorio rep = new ContaRepositorio();
            rep.Insert(c);
        }

        public void Atualizar(Conta c)
        {
            ContaRepositorio rep = new ContaRepositorio();
            rep.Update(c);
        }

        public void Excluir(Conta c)
        {
            ContaRepositorio rep = new ContaRepositorio();
            rep.Delete(c);
        }

        public List<Conta> ConsultarTodos()
        {
            ContaRepositorio rep = new ContaRepositorio();
            return rep.FindAll();
        }

        public Conta ConsultarPorId(int id)
        {
            ContaRepositorio rep = new ContaRepositorio();
            return rep.FIndById(id);
        }
    }
}
