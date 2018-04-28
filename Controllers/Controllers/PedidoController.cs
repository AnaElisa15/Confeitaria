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
        static public void SalvarPedido(Pedidos pedido)
        {

            ContextoSingleton.Instancia.TblPedido.Add(pedido);
            ContextoSingleton.Instancia.SaveChanges();
        }
        public static List<Pedidos> ListarTodosPedidos()
        {
            return ContextoSingleton.Instancia.TblPedido.ToList();
        }

        static public Pedidos PesquisarPorID(int idPedido)
        {
            return ContextoSingleton.Instancia.TblPedido.Find(idPedido);
        }

        static public void ExcluirPedido(int idPedido)
        {

            Pedidos p = ContextoSingleton.Instancia.TblPedido.Find(idPedido);

            ContextoSingleton.Instancia.Entry(p).State =
                System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
        }
    }
}
