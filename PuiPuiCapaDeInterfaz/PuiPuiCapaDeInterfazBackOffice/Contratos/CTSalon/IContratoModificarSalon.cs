﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon
{
    /// <summary>
    /// Interfaz que implementa tods los de datos primitivos
    /// que pertenecen a las Vista modificar.
    /// </summary>
    public interface IContratoModificarSalon
    {

        Boolean RBStatus_Activo { set; get; }
        Boolean RBStatus_Inactivo { set; get; }
        String TXTSalonModificar{ set; get; }
        String TXTSalonCodigo { set; get; }
        int TxtCapacidad { set; get; }
        int SessionID{ set; get; }
    }
}
