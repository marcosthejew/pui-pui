﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio
{
    public interface IContratoDesactivarEjercicio
    {
        String Ejercicio { get; }
        String Exito { get; set; }
    }
}
