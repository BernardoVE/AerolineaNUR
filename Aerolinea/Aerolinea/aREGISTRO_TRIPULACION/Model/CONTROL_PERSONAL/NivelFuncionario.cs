using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.aREGISTRO_TRIPULACION.Model.CONTROL_PERSONAL
{
    public class NivelFuncionario : AggregateRoot<Guid>
    {
        public string IdNivel { get; private set; }
        public string Nivel { get; private set; }
        public ushort Basico { get; private set; }
        public NivelFuncionario(string idNivel, string nivel, ushort basico)
        {
            IdNivel = idNivel;
            Nivel = nivel;
            Basico = basico;
        }
    }

}
