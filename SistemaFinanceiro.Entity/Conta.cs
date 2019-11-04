using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entity
{
    public class Conta
    {
        #region Atributos
        private int idConta;
        private decimal saldo;
        private Usuario usuario;
        private int idUsuario;

        private List<Receita> receitas;
        private List<Despesa> despesas;
        #endregion

        #region Construtores
        public Conta()
        {

        }

        public Conta(int idConta, decimal saldo)
        {
            IdConta = idConta;
            Saldo = saldo;
        }
        #endregion

        #region MetodosAcesso
        public int IdConta
        {
            set { IdConta = value; }
            get { return idConta; }
        }

        public decimal Saldo
        {
            set { saldo = value; }
            get { return saldo; }
        }

        public int IdUsuario
        {
            set { idUsuario = value; }
            get { return idUsuario; }
        }

        public Usuario Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }

        public List<Receita> Receitas
        {
            set { receitas = value; }
            get { return receitas; }
        }

        public List<Despesa> Despesas
        {
            set { despesas = value; }
            get { return despesas; }
        }
        #endregion

        #region OverrideString

        public override string ToString()
        {
            return "IdConta: " + idConta + ", saldo: " + saldo;
        }
        #endregion

    }
}
