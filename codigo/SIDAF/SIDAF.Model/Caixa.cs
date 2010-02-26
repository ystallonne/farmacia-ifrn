using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    class Caixa : SIDAF.Model.ICaixa
    {
        #region Fields
        private Nullable<int> oid;

        public Nullable<int> Oid
        {
            get { return oid; }
            set { oid = value; }
        }
        private DateTime dataAbertura;

        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }
        private DateTime dataFechamento;

        public DateTime DataFechamento
        {
            get { return dataFechamento; }
            set { dataFechamento = value; }
        }
        private Funcionario func;
        private Venda venda;
        private Entrada entrada;
        private Saida saida;
        private Estorno estorno;

        #endregion
    }
}
