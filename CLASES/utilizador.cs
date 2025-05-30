using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.CLASES
{

    public class utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Gestor : utilizador
    {
        public Departamento Departamento { get; set; }
        public List<Programador> Programadores { get; set; }
    }

    public class Programador : utilizador
    {
        public NivelExp NivelExperiencia { get; set; }
        public int GestorId { get; set; }
        public Gestor Gestor { get; set; }
    }

    public enum Departamento
    { IT, Marketing, Administracao }

    public enum NivelExp
    { Junior, Senior }
}
