using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExcepcionConexionBD : AExcepcionLogicaPuiPui
    {
        /// <summary>
        /// Instancia una excepcion de conexion a la base de datos con el 
        /// siguiente mensaje: "No se puede establecer la conexion con la base 
        /// de datos"
        /// </summary>
        public ExcepcionConexionBD() : base("No se puede establecer la conexion"
                                            + "con la base de datos")
        { 

        }

        /// <summary>
        /// Instancia una excepcion de conexion a la base de datos con el 
        /// siguiente mensaje: "No se puede establecer la conexion con la base 
        /// de datos" y especificando la excepcion interna que dio lugar a esta
        /// nueva excepcion.
        /// </summary>
        /// <param name="excepcionInterna">
        /// la excepcion de sistema que genero esta nueva excepcion.
        /// </param>
        public ExcepcionConexionBD(System.Exception excepcionInterna)
                : base("No se puede establecer la conexion con la base de datos"
                        , excepcionInterna)
        {

        }
    }
}