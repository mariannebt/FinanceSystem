using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.BLL.Exceptions
{
    public class UsuarioNaoLocalizadoException : Exception
    {
        public override string Message
        {
            get
            {
                return "Senha ou login incorretos";
            }
        }
    }
}
