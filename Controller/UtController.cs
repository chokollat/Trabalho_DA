using iTasks.CLASES;
using iTasks.DB_s;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iTasks.CLASES.utilizador;

namespace iTasks
{
    class UtController
    {
        public void AdicionarUtilizador(utilizador u)
        {
            using (var db = new BDContext())
            {
                db.Utilizadores.Add(u);
                db.SaveChanges();
            }
        }

        public List<utilizador> ListarUtilizadores()
        {
            using (var db = new BDContext())
            {
                return db.Utilizadores.ToList();
            }
        }

        public void AdicionarGestor(Gestor g)
        {
            using (var db = new BDContext())
            {
                db.Gestores.Add(g);
                db.SaveChanges();
            }
        }

        public List<Gestor> ListarGestores()
        {
            using (var db = new BDContext())
            {
                return db.Gestores.ToList();
            }
        }

        
        public void AdicionarProgramador(Programador p)
        {
            using (var db = new BDContext())
            {
                db.Programadores.Add(p);
                db.SaveChanges();
            }
        }

        public List<Programador> ListarProgramadores()
        {
            using (var db = new BDContext())
            {
                return db.Programadores.ToList();
            }
        }
    }
}
