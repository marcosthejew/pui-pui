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
    /// Clase consultar salon por id
    /// que implementa el comando consultar salon por id
    /// </summary>
    public class ComandoConsultarSalonesPorId: AComando<Salon>
    {
        private int _id;
        private Salon _Salon;
        /// <summary>
        /// constructor de la clase que recibe como parametro el atributo necesario para la ejecucion del comando.
        /// </summary>
        /// <param name="id"></param>
        public ComandoConsultarSalonesPorId(int id)
        {
            _id = id;
        }
        /// <summary>
        /// metodo que implementa la ejecucion del comando consultar salon por id y devuele el salon del id recibido en el constructor de la clase
        /// </summary>
        public override Salon Ejecutar()
        {
            ISalonDAO salonDao=(ISalonDAO) 
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            _Salon = (Salon) salonDao.ConsultarPorId(_id);
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar salones por id");
            return (_Salon);
        }
        
    }
}