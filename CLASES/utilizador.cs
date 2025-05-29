using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.CLASES
{
    public enum Departamento { IT, Marketing, Administracao }
    public enum NivelExp { Junior, Senior}
    public class utilizador
    {
        public class Utilizador : utilizador
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class Programador : utilizador
        {
            public NivelExp NivelExperiencia { get; set; }

            // Chave estrangeira para o Gestor
            public int GestorId { get; set; }
            public Gestor Gestor { get; set; }
        }

        public class Gestor : utilizador
        {
            public Departamento Departamento { get; set; }

            // Relação 1:N com Programadores
            public List<Programador> Programadores { get; set; }
        }
    }
}
