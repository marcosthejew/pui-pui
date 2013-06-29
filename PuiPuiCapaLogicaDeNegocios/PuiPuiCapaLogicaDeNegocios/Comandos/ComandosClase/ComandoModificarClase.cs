using PuiPuiCapaLogicaDeNegocios.Bitacora;
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
        /// Constructor de la clase por defecto recibe el id y el nuevo objeto
        /// conformado por los nuevos atributos que formaran la clase
        /// </summary>
        /// <returns></returns>
        public ComandoModificarClase(int id, Clase clase)
        {
            _id = id;
            _clase = clase;
        }

        /// <summary>
        /// Ejecuta el comando retorna true de modifcarse el salon y false de no hacerlo
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {
            bool modifico = false;
            IClaseDAO claseDao= (IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            claseDao = new DAOs.DAOsClases.ClaseSQLServerDAO();
            modifico = claseDao.Modificar(_id, _clase);
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando modificar clase");
            return (modifico);

        }
    }
}