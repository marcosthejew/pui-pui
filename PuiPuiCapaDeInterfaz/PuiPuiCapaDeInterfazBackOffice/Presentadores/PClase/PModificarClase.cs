﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase;
using PuiPuiCapaDeInterfazBackOffice.LogicaClase;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase
{

    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// Vista de modificar clase con la capa de Logica de negocios.
    /// </summary>
    public class PModificarClase
    {
        IContratoModificaClase _modificar;
        public PModificarClase(IContratoModificaClase vista_modificar)
        {
            _modificar = vista_modificar;
        }
        /// <summary>
        /// Devuelve un booleano que determina si la clase se modifico o no 
        /// en la base de datos
        /// </summary>
        /// <returns>boolean</returns>
        public bool ModificarClase()
        {

            FachadaClasesSoapClient claseModificar = new FachadaClasesSoapClient();
            if (_modificar.RBStatus_Activo == true)
            {
                return claseModificar.ServicioModificarClase(_modificar.idClase, _modificar.TxtClaseModificar, 0, _modificar.TADescripcionModificar, 0);
            }
            else
            {
                return claseModificar.ServicioModificarClase(_modificar.idClase, _modificar.TxtClaseModificar, 0, _modificar.TADescripcionModificar, 1);
            }
          
        }
    }
}