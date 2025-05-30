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

        public void AdicionarGestor(string nome, string username, string password, Departamento departamento)
        {
            using (var db = new BDContext())
            {

                var gestor = new Gestor
                {
                    Nome = nome,
                    Username = username,
                    Password = password,
                    Departamento = departamento
                };

                db.Gestores.Add(gestor);
                db.SaveChanges();
            }
        }


        public void AdicionarProgramador(string nome, string username, string password, NivelExp nivelExp, int gestorId)
        {
            using (var db = new BDContext())
            {

                var programador = new Programador
                {
                    Nome = nome,
                    Username = username,
                    Password = password,
                    NivelExperiencia = nivelExp,
                    GestorId = gestorId
                };

                db.Programadores.Add(programador);
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

        public List<Programador> ListarProgramadores()
        {
            using (var db = new BDContext())
            {
                return db.Programadores.ToList();
            }
        }
    }
}