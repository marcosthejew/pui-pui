using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;
using PuiPuiCapaDeInterfazBackOffice.LogicaClase;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// Vista de Agregar clase con la capa de Logica de negocios.
    /// </summary>
    public class PAgregarClase
    {
        IContratoAgregarClase agregarclase;

        public PAgregarClase(IContratoAgregarClase vistaAgregar) {

            agregarclase = vistaAgregar;
        
        }
        /// <summary>
        /// Inserta una clase del GYM en la base de datos pasando por la Logica de negocios
        /// devuelve un booleano depende del caso si se inserto o no
        /// </summary>
        /// <returns>boolean</returns>
        public Boolean InsertarClase()
        {
            FachadaClasesSoapClient insertar = new FachadaClasesSoapClient();
           int seInserto= insertar.ServicioAgregarClase(agregarclase.TxtnombreClaseNueva, 0, agregarclase.TxtDescripcionClaseNueva, 0);
           if (seInserto == 0)
               return true;
           else
               return false;
        }



    }
}