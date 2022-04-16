using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.aREGISTRO_TRIPULACION.Model.ValueObject
{
    public record ElaboracionPlanilla
    {
        public int Value { get; }
        public ElaboracionPlanilla(int value)
        {
            if (value >= 1 && value <= 12)
            {
                Value = value;
            } else
                //throw new BussinessRuleValidationException("Price value cannot be negative");
                Console.WriteLine("error mes");
        }
    }
}


        /*public static implicit operator decimal(PrecioValue value)
        {
            return value.Value;
        }

        public static implicit operator PrecioValue(decimal value)
        {
            return new PrecioValue(value);
        }*/

