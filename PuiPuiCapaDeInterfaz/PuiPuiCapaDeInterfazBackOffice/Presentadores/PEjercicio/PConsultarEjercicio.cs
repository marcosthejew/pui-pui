﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PConsultarEjercicio
    {
        private IContratoConsultarEjercicio _vistaConsultarEjercicio;

        public PConsultarEjercicio(IContratoConsultarEjercicio laVistaConsultarEjercicio)
        {
            _vistaConsultarEjercicio = laVistaConsultarEjercicio;
        }


    }

}