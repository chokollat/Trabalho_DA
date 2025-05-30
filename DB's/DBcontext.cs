using iTasks.CLASES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iTasks.CLASES.utilizador;





namespace iTasks.DB_s
{
    class BDContext : DbContext
    {
        public DbSet<utilizador> Utilizadores { get; set; }
        public DbSet<Gestor> Gestores { get; set; }
        public DbSet<Programador> Programadores { get; set; }


    }
}
