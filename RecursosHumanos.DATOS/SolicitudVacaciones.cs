﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos.DATOS
{
    public class SolicitudVacaciones
    {
        public int IdSolicitud { get; set; }

        public string Cedula { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFinal { get; set; }

        public int TotalDias { get; set; }

        public bool Condicion { get; set; }

    }
}
