using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    class ItemEstoque
    {

        #region atributos

        private Nullable<int> id;

        public Nullable<int> Id
        {
            get { return id; }
        }
        
        private Nullable<string> nome;

        public Nullable<string> nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private Nullable<int> quantidade;

        public Nullable<int> Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private Nullable<DateTime> dataCadastro;

        public Nullable<DateTime> DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        private Nullable<DateTime> dataUIAlteracao;

        public Nullable<DateTime> DataUIAlteracao
        {
            get { return dataUIAlteracao; }
            set { dataUIAlteracao = value; }
        }

        private Nullable<double> precoCusto;

        public Nullable<double> PrecoCusto
        {
            get { return precoCusto; }
            set { precoCusto = value; }
        }

        private Nullable<double> precoVenda;

        public Nullable<double> PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }


        #endregion


        #region construtores

        public ItemEstoque()
        { 
         //Construtor padrão           
        }

        #endregion


        #region metodos

        public override string ToString()
        {
            return "Código: " + id.ToString() + " Item:" + nome;

        }

        #endregion

    }
}
