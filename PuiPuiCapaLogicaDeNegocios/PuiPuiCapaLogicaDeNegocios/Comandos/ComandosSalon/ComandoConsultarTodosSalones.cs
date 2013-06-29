using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    /// <summary>
    /// Comando que consulta todos los salones en el sistema.
    /// </summary>
    public class ComandoConsultarTodosSalones : AComando<List<Salon>>
    {
      

        /// <summary>
        /// Constructor de la clase por defecto.
        /// </summary>
        /// <returns></returns>
        public ComandoConsultarTodosSalones()
        {
         
        }

        /// <summary>
        /// Ejecuta el comando y devuelve todos los salones del sistema.
        /// </summary>
        /// <returns></returns>
        public override List<Salon> Ejecutar()
        {  
            ISalonDAO salonDao=(ISalonDAO) 
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon= 
            (salonDao.ConsultarTodos()).Cast<Salon>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultarTodosSalones");
            return (listaSalon);

        }
    }
}