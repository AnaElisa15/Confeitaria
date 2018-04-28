using Models;
using Sistema.Models.DAO;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {
        // INSERT
        public static void SalvarCliente(Clientes cliente)
        {
            ContextoSingleton.Instancia.TblCliente.Add(cliente);
            ContextoSingleton.Instancia.SaveChanges();
        }

        public static List<Clientes> ListarTodosClientes()
        {

            return ContextoSingleton.Instancia.TblCliente.Include("_Endereco").ToList(); //IQueryable
        }

        public static void EditarCliente(int id, Clientes novoCliente)
        {

            Clientes clienteEdit = PesquisarPorID(id);

            if (clienteEdit != null)
            {
                clienteEdit.Nome = novoCliente.Nome;
                clienteEdit.Cpf = novoCliente.Cpf;
                clienteEdit.Telefone = novoCliente.Telefone;
            }

            ContextoSingleton.Instancia.Entry(clienteEdit).State =
                System.Data.Entity.EntityState.Modified;

            ContextoSingleton.Instancia.SaveChanges();
        }

        public static void ExcluirCliente(int id)
        {

            Clientes clienteAtual = ContextoSingleton.Instancia.TblCliente.Find(id);

            ContextoSingleton.Instancia.Entry(clienteAtual).State =
                System.Data.Entity.EntityState.Deleted;
            ContextoSingleton.Instancia.SaveChanges();

        }

        public static List<Clientes> PesquisarPorNome(string nome)
        {

            var c = (from x in ContextoSingleton.Instancia.TblCliente
                     where x.Nome.ToLower().Equals(nome.ToLower())
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

        public static Clientes PesquisarPorID(int IDCliente)
        {
            return ContextoSingleton.Instancia.TblCliente.Include("_Endereco").SingleOrDefault
                (x => x.ClienteID == IDCliente && x._Endereco.EnderecoID == x.EnderecoID);
        }

    }
}