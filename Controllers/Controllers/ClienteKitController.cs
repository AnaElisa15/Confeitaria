using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClienteKitController
    {
        public static void SalvarItem(ClienteKitController novo)
        {
            ContextoSingleton.Instancia.TblClienteKit.Add(novo);
            ContextoSingleton.Instancia.SaveChanges();
        }

    }
}
