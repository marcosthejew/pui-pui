using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    /// <summary>
    /// Comando que modifica salones.
    /// </summary>
    public class ComandoModificarClase : AComando<bool>
    {
        private int _id;
        private AEntidad _clase;
        /// <summary>
        /// Constructor de la clase por defecto.
        /// </summary>
        /// <returns></returns>
        public ComandoModificarClase(int id, Clase clase)
        {
            _id = id;
            _clase = clase;
        }

        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {
            bool modifico = false;
            IClaseDAO claseDao= (IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            claseDao = new DAOs.DAOsClases.ClaseSQLServerDAO();
            modifico = claseDao.Modificar(_id, _clase);
            return (modifico);

        }
    }
}