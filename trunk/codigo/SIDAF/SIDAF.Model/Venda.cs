using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIDAF.Model.Interface;



namespace SIDAF.Model
{
    class Venda : IVenda, SIDAF.Model.IVenda
    {
        #region Fields
        private Nullable<int> oid;

        public Nullable<int> Oid
        {
            get { return oid; }
            set { oid = value; }
        }

        private DateTime dataVenda;

        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        private Funcionario func;
        private int tipoVenda;
        private List<ItemVenda> itens;
        private Empresa emp;
        
        #endregion Fields
    }
}
