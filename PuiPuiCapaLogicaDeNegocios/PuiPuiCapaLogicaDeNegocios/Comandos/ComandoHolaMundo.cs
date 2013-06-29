using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos
{
    /// <summary>
    /// Comando que genera un string de "HolaMundo".
    /// </summary>
    public class ComandoHolaMundo : AComando<string>
    {
        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override string Ejecutar()
        {
            return "Hola Mundo";
        }
    }
}