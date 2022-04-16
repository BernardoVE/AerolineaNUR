using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.aREGISTRO_TRIPULACION.Model.CONTROL_PERSONAL
{
    public class KardexFuncionario : AggregateRoot<Guid>
    {
        public string IdFuncionario { get; private set; }
        public string IdSitio { get; private set; }
        public string IdCargo { get; private set; }
        public string IdNivel { get; private set; }
        public DateTime FechaIngreso { get; private set; }
        public bool  Estado { get; private set; }
           
        public KardexFuncionario(string idFuncionario, string idSitio, string idCargo, string idNivel, DateTime fechaIngreso, bool estado)
        {
            IdFuncionario = idFuncionario;
            IdSitio = idSitio; 
            IdCargo = idCargo;
            IdNivel = idNivel;
            FechaIngreso = fechaIngreso;
            Estado = estado;
         }
     }
 }
