using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    /// <summary>
    /// Comando que consulta todos los clase en el sistema.
    /// </summary>
    public class ComandoConsultarTodasClases : AComando<List<Clase>>
    {
      

        /// <summary>
        /// Constructor de la clase por defecto.
        /// </summary>
        /// <returns></returns>
        public ComandoConsultarTodasClases()
        {
         
        }

        /// <summary>
        /// Ejecuta el comando y devuelve una lista de todas las clases en el sistema
        /// </summary>
        /// <returns></returns>
        public override List<Clase> Ejecutar()
        {  
            IClaseDAO ClaseDao=(IClaseDAO) 
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            List<Clase> listaClase= 
            (ClaseDao.ConsultarTodos()).Cast<Clase>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar capacidad mayor salon");
            return (listaClase);

        }
    }
}