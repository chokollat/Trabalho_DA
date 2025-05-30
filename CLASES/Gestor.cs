using iTasks.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks
{
    public enum Departamento { IT, Marketing, Administracao }
    public class Gestor : utilizador
    {
        public Departamento Departamento { get; set; }

        public List<Programador> Programadores { get; set; }
    }
}
