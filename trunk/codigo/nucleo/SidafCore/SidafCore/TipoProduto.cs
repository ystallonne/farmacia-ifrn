using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    class TipoProduto : SidafCore.ITipoProduto
    {

        #region atributos

        private Nullable<int> id;

        public Nullable<int> Id
        {
            get { return id; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region construtores

        public TipoProduto() { 
         //Construtor padrão           
        }

        public TipoProduto(Nullable<int> id)
        {
            this.id = id;
        }

        public TipoProduto(Nullable<int> id, string nome)
        {
            this.nome = nome;
        }

        #endregion



        public override string ToString()
        {
            return "Código: " + id.ToString() + " Tipo:" + nome;
                               
        }



    }
}
