using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Bitacora;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    /// <summary>
    /// Comando que inserta un nuevo salon.
    /// </summary>
    public class ComandoAgregarClase : AComando<int>
    {
        private Clase clase;

        public ComandoAgregarClase(Clase clase) {
            this.clase = clase;
        }

        /// <summary>
        /// Ejecuta el comando que agrega una clase y retona un 
        /// entero que indica si se agrego(0)
        /// o no (1)
        /// </summary>
        /// <returns></returns>
        public override int Ejecutar()
        {
            int agrego = 1;
            IClaseDAO claseDao=(IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            agrego=claseDao.Agregar(this.clase);
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando insertar clase");
            return (agrego);
            
        }
    }
}