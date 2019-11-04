using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entity
{
    public class Despesa : Valores
    {
        private DateTime dataVencimento;

        public Despesa()
        {

        }
        public Despesa(int id, string nome, decimal valor, DateTime data, string descricao, DateTime dataVencimento)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Data = data;
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }

        
        public DateTime DataVencimento
        {
            set { dataVencimento = value; }
            get { return dataVencimento; }
        }

        public override string ToString()
        {
            return "Id: " + Id + ", nome: " + Nome + ", valor: " + Valor + ", data pagamento: " + Data  + ", data de vencimento: "
                + DataVencimento + ", descrição:" + Descricao;
        }
    }
}
