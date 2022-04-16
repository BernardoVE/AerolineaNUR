using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.aREGISTRO_TRIPULACION.Model.CONTROL_PERSONAL
{
    public class Oficinas : AggregateRoot<Guid>
    {
        public string IdSitio { get; private set; }
        public string Pais { get; private set; }
        public string Departamento { get; private set; }
        public string Municipio { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }
        public string Continente { get; private set; }

        public Oficinas(string idSitio, string pais, string departamento, string municipio, string direccion, string telefono,string continente)
        {
            IdSitio = idSitio;
            Pais = pais;
            Departamento = departamento;
            Municipio = municipio;
            Direccion = direccion;
            Telefono = telefono;
            Continente = continente;
        }
    }

}
