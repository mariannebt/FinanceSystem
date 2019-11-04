using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entity
{
    public class Valores
    {
        #region Atributos
        private int id;
        private string nome;
        private decimal valor;
        private DateTime data;
        private string descricao;
        private int idConta;
        private Conta conta;
        #endregion

        #region Construtores
        public Valores()
        {

        }

        public Valores(int id, string nome, decimal valor, DateTime data, string descricao)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Data = data;
            Descricao = descricao;
        }


        #endregion

        #region MetodosAcesso
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Nome
        {

            set { nome = value; }
            get { return nome; }
        }

        public decimal Valor
        {
            set { valor = value; }
            get { return valor; }
        }

        public DateTime Data
        {
            set { data = value; }
            get { return data; }
        }

        public string Descricao
        {
            set { descricao = value; }
            get { return descricao; }
        }

        public int IdConta
        {
            set { idConta = value; }
            get { return idConta; }
        }

        public Conta Conta
        {
            set { conta = value; }
            get { return conta; }
        }

        
        #endregion

        #region OverrideString
        public override string ToString()
        {
            return "Id: " + id + ", nome: " + nome + ", valor: " + valor + ", data: " + data + ", descrição:" + descricao;
        }
        #endregion

    }
}
