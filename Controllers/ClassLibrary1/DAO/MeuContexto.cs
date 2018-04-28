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

     public DbSet<Clientes> TblCliente { get; set; }

     public DbSet<Endereco> TblEndereco { get; set; }

     public DbSet<Kits> TblKit { get; set; }

     public DbSet<Pedidos> TblPedido { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         }

    }

    
}
