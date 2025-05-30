using iTasks.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks
{
    public enum NivelExp { Junior, Senior }
    public class Programador : utilizador
    {
            public NivelExp NivelExperiencia { get; set; }

            // Chave estrangeira para o Gestor
            public int GestorId { get; set; }
            public Gestor Gestor { get; set; }
        
    }
}
