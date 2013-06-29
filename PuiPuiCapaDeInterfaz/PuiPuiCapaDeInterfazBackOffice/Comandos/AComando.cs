using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos
{
    /// <summary>
    /// Clase abstracta que representa la familia de comandos.
    /// </summary>
    /// <typeparam name="T">
    /// El tipo de dato que ha de retornar el comando al ejecutarse.
    /// </typeparam>
    public abstract class AComando<T>
    {
        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        public abstract T Ejecutar();
    }
}