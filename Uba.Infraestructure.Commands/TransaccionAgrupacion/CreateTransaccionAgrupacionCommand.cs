﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Infraestructure.Commands;

namespace Uba.Application.Commands.TransaccionAgrupacion
{
    public class CreateTransaccionAgrupacionCommand : Command
    {
        public int IdClase { get; set; }
        public int IdAgrupacion { get; set; }
        public int IdTransaccion { get; set; }


        public CreateTransaccionAgrupacionCommand(int clase, int agrupacion, int transaccion)
        {
            IdClase = clase;
            IdAgrupacion = agrupacion;
            IdTransaccion = transaccion;
        }
    }
}
