using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIDAF.Model
{
    class Pedido 
    {

        #region atributos

        private Nullable<int> id;

        public Nullable<int> Id
        {
            get { return id; }
        }
        private DateTime data;

        public DateTime data
        {
            get { return data; }
            set { data = value; }
        }

        private StatusPedido status;

        public StatusPedido status
        {
            get { return status; }
            set { status = value; }
        }



        #endregion

    

    }
}
