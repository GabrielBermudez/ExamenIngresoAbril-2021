using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoAbril_2021
{
    class SocioVip: Socio
    {
        private Double cuota_mensual;

        public double Cuota_mensual { get => cuota_mensual; set => cuota_mensual = value; }
    }
}
