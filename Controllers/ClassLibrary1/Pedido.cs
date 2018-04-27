using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public int KitID { get; set; }
        public string DataEntrega { get; set; }
    }
}
