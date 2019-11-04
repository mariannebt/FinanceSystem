using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SistemaFinanceiro.Entity;
using SistemaFinanceiro.DAL.Context;

namespace SistemaFinanceiro.DAL.Repositories
{
    public class UsuarioRepositorio : BaseRepositorios<Usuario>
    {
        public Usuario FindUser(string email, string senha)
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<Usuario>().Find(email, senha);

            }
        }

    }
}
