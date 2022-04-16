using SharedKernel.Core;
using Aerolinea.aREGISTRO_TRIPULACION.Model.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.aREGISTRO_TRIPULACION.Model.PLANILLA_SUELDOS
{
    public class PlanillaFuncionario : AggregateRoot<Guid>
    {
        
        public byte IdMes { get; private set; }
        public short IdGestion { get; private set; }
        public string IdFuncionario { get; private set; }
        public ushort Basico { get; private set; }
        public byte DiasTrabajados { get; private set; }
        public double BonoMillas { get; private set; }
        public decimal BonoMinutosHoraVuelo { get; private set; }
        public decimal BonoAntiguedad { get; private set; }
        public decimal TotalGanado { get; private set; }
        public decimal AFPPrev { get; private set; }
        public decimal AFPFuturo { get; private set; }
        public decimal DstoSindicato { get; private set; }
        public decimal Deudas { get; private set; }
        public decimal OtrosDscto { get; private set; }
        public decimal TotalDescuento { get; private set; }
        public decimal LiquidoPagable { get; private set; }
        public DateTime FechaPlanilla { get; private set; }

        public PlanillaFuncionario(byte idMes,short idGestion,string idFuncionario,ushort basico, byte diasTrabajados,double bonoMillas,decimal bonoMinutosHoraVuelo,decimal bonoAntiguedad,decimal totalGanado,decimal aFPPrev,decimal aFPFuturo,decimal dstoSindicato,decimal deudas,decimal otrosDscto,decimal totalDescuento,decimal liquidoPagable,DateTime fechaPlanilla)

        {
            IdMes = idMes;
            IdGestion = idGestion;
            IdFuncionario = idFuncionario;
            Basico = basico;
            DiasTrabajados = diasTrabajados;
            BonoMillas = bonoMillas;
            BonoMinutosHoraVuelo = bonoMinutosHoraVuelo;
            BonoAntiguedad = bonoAntiguedad;
            TotalGanado = totalGanado;
            AFPPrev = aFPPrev;
            AFPFuturo = aFPFuturo;
            DstoSindicato = dstoSindicato;
            Deudas = deudas;
            OtrosDscto = otrosDscto;
            TotalDescuento = totalDescuento;
            LiquidoPagable = liquidoPagable;
            FechaPlanilla = fechaPlanilla;
            }
    }

}
