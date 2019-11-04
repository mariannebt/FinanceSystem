using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entity
{
    public class Usuario
    {
        #region Atributos
        private int cpf;
        private string email;
        private string nome;
        private string senha;
        private DateTime dataCadastro;
        private List<Conta> contas;
        #endregion 

        #region Construtores
        public Usuario()
        {

        }

        public Usuario(int cpf, string email, string nome, string senha, DateTime dataCadastro)
        {
            Cpf = cpf;
            Email = email;
            Nome = nome;
            Senha = senha;
            DataCadastro = dataCadastro;
        }
        #endregion

        #region MetodosAcesso
        public int Cpf
        {
            set{ cpf = value; }
            get { return cpf; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string Senha
        {
            set { senha = value; }
            get { return senha; }
        }

        public DateTime DataCadastro
        {
            set { dataCadastro = value; }
            get { return dataCadastro; }
        }

        public List<Conta> Contas
        {
            set { contas = value; }
            get { return contas; }
        }
        #endregion

        #region OverrideString
        public override string ToString()
        {
            return "Cpf: " + cpf + ", nome: " + nome + ", e-mail: " + email + ", data de cadastro: " + dataCadastro;
        }

        #endregion
    }
}
