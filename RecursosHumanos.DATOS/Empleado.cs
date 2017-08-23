﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos.DATOS
{
    public class Empleado
    {
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string EstadoCivil { get; set; }

        public string Password { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int IdExpediente { get; set; }

        public int IdDepartamento { get; set; }

        public int IdRol { get; set; }

        public bool Estado { get; set; }

        public byte[] Imagen { get; set; }

    }
}
