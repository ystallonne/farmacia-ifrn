using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    class Estorno : SIDAF.Model.IEstorno
    {
        #region Fields
        private Nullable<int> oid;

        public Nullable<int> Oid
        {
            get { return oid; }
            set { oid = value; }
        }
        private DateTime dataEstorno;

        public DateTime DataEstorno
        {
            get { return dataEstorno; }
            set { dataEstorno = value; }
        }
        private int tipoEstorno;

        public int TipoEstorno
        {
            get { return tipoEstorno; }
            set { tipoEstorno = value; }
        }
        private Venda venda;
        private Funcionario func;
        #endregion Fields
    }
}
