using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    public class Estorno : SIDAF.Model.IEstorno
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

        public Venda Venda
        {
            get { return venda; }
            set { venda = value; }
        }
        private Funcionario func;

        public Funcionario Func
        {
            get { return func; }
            set { func = value; }
        }
        #endregion Fields
    }
}
