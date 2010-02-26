using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    class Produto
    {

        #region atributos

        private Nullable<int> id;

        public Nullable<int> Id
        {
            get { return id; }
        }
        private string principioAtivo;

        public string PrincipioAtivo
        {
            get { return principioAtivo; }
            set { principioAtivo = value; }
        }

        #endregion

        #region construtores

        public Produto() { 
         //Construtor padrão           
        }

        public Produto(Nullable<int> id)
        {
            this.id = id;
        }

        public Produto(Nullable<int> id, Nullable<string> principio)
        {
            this.id = id;
            this.principioAtivo = principio;
        }

        #endregion

        #region metodos

        public override string ToString()
        {
            if(id.HasValue)
                return "Código: " + id.ToString() + " Princípio Ativo:" + principioAtivo;
            return "Código: 0 Princípio Ativo:" + principioAtivo;
        }

        #endregion

    }
}
