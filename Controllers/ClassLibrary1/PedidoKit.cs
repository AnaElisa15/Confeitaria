using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PedidoKit
    {
        public int PedidoKitID { get; set; }
        public int NumeroPedidoID { get; set; }
        public int ClientesKitID { get; set; }
        public Pedido _Pedido { get; set; }
        public ClienteKit _ClientesKit { get; set; }

    }
}
