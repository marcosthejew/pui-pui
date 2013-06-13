using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    /// <summary>
    /// Clase abstracta que tiene como finalidad especificar una fabrica para la
    /// creacion de objetos DAO segun la fuente de datos.
    /// </summary>
    public abstract class AFabricaDAO
    {
        /// <summary>
        /// Devuelve la instancia de la clase FabricaSQLServerDAO.
        /// </summary>
        /// <returns></returns>
        public static FabricaSQLServerDAO CrearFabricaSQLServerDAO()
        {
            return FabricaSQLServerDAO.obtenerInstancia();
        }
    }
}