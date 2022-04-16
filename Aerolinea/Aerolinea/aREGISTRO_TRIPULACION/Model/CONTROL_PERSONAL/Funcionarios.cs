using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.aREGISTRO_TRIPULACION.Model.CONTROL_PERSONAL
{
    public class Funcionarios : AggregateRoot<Guid>
    {
        public string IdFuncionario { get; private set; }
        public string Paterno { get; private set; }
        public string Materno { get; private set; }
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }
        public string CtaBanco { get; private set; }
        
        public Funcionarios(string idFuncionario, string paterno, string materno, string nombre, string direccion, string telefono, string ctaBanco)
        {
            //Id = Guid.NewGuid(); //IdFuncionario
            IdFuncionario = idFuncionario;
            Paterno= paterno;
            Materno= materno;
            Nombre= nombre;
            Direccion= direccion;
            Telefono= telefono;
            CtaBanco= ctaBanco;
        }
    }
}

