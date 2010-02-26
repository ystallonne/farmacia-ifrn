using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    class Especificacao
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


        #endregion

        #region construtores

        public Especificacao()
        { 
         //Construtor padrão           
        }


        #endregion

        #region metodos

        public override string ToString()
        {
            return "Código: " + id.ToString() + " Especificação:" + nome;

        }

        #endregion

    }
}
