using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PedidoController
    {
        // INSERT
        public static void SalvarPedido(Pedido novo)
        {
            ContextoSingleton.Instancia.TblPedido.Add(novo);
            ContextoSingleton.Instancia.SaveChanges();
        }
    }
}