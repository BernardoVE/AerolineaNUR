using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.aREGISTRO_TRIPULACION.Model.CONTROL_PERSONAL
{
    public class CargoFuncionario : AggregateRoot<Guid>
    {
        public string IdCargo { get; private set; }
        public string TipoCargo { get; private set; }
        public string DescripcionCargo { get; private set; }
        public CargoFuncionario(string idCargo, string tipoCargo, string descripcionCargo)
        {
            IdCargo = idCargo;
            TipoCargo = tipoCargo;
            DescripcionCargo = descripcionCargo;
        }
    }
}
