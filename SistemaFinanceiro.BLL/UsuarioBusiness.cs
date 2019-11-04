using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFinanceiro.Entity;
using SistemaFinanceiro.DAL.Repositories;
using SistemaFinanceiro.BLL.Exceptions;

namespace SistemaFinanceiro.BLL
{
    public class UsuarioBusiness
    {
        public void Cadastrar(Usuario u)
        {
            u.DataCadastro = DateTime.Now;
            UsuarioRepositorio rep = new UsuarioRepositorio();
            rep.Insert(u);
            
        }

        public void Atualizar(Usuario u)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            rep.Update(u);
        }

        public void Excluir(Usuario u)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            rep.Delete(u);
        }

        public List<Usuario> ConsultarTodos()
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            return rep.FindAll();
        }

        public Usuario AutenticarUsuario(string email, string senha)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            Usuario u = rep.FindUser(email, senha);

            if(u != null)
            {
                return u;
            }
            else
            {
                throw new UsuarioNaoLocalizadoException();
            }
        }
        public Usuario ConsultarPorId(int id)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            return rep.FIndById(id);
        }
    }
}
