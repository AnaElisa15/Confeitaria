using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class KitController
    {

        // INSERT
        public static void SalvarKit(Kits kit)
        {
            ContextoSingleton.Instancia.TblKit.Add(kit);
            ContextoSingleton.Instancia.SaveChanges();
        }

        public static List<Kits> ListarTodosKits()
        {
            List<Kits> list = ContextoSingleton.Instancia.TblKit.ToList(); //IQueryable

            if (list.Count > 0)
            {
                return list;
            }
            else
            {
                return null;
            }
        }

        public static void ExcluirKit(int id)
        {

            Kits kitAtual = ContextoSingleton.Instancia.TblKit.Find(id);

            ContextoSingleton.Instancia.Entry(kitAtual).State =
                System.Data.Entity.EntityState.Deleted;
            ContextoSingleton.Instancia.SaveChanges();

        }

        public static Kits PesquisarPorID(int IDKit)
        {
            return ContextoSingleton.Instancia.TblKit.Find(IDKit);
        }

        public static List<Kits> PesquisarPorNome(string nome)
        {

            var c = (from x in ContextoSingleton.Instancia.TblKit
                     where x.Nome.ToLower().Trim().Equals(nome.ToLower().Trim())
                     select x).ToList();

            if (c.Count > 0)
            {
                return c;
            }
            else
            {
                return null;
            }
        }
    }
}