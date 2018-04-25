using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Models.DAO
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        { 
        Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MeuContexto>());
        }

     public DbSet<Cliente> TblCliente { get; set; }

     public DbSet<Endereco> TblEndereco { get; set; }

     public DbSet<Kit> TblKit { get; set; }

     public DbSet<Pedido> TblPedido { get; set; }

     public DbSet<ClienteKit> TblClienteKit { get; set; }

     public DbSet<PedidoKit> TblPedidoKit { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         }

    }

    
}
