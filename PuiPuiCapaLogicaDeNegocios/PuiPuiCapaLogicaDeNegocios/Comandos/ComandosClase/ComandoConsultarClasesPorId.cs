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
    public class ComandoConsultarClasesPorId: AComando<Clase>
    {
        private int _id;
        private Clase _Clase;
        /// <summary>
        /// Constructor que recibe el id de la clase a constultar
        /// </summary>
        /// <param name="id"></param>
        public ComandoConsultarClasesPorId(int id)
        {
            _id = id;
        }

        /// <summary>
        ///comando que retorna la clase busqueda de encontrarse el id
        /// </summary>
         
        public override Clase Ejecutar()
        {
            IClaseDAO claseDao=(IClaseDAO) 
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            _Clase = (Clase) claseDao.ConsultarPorId(_id);
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar clases por id");
            return (_Clase);
        }
        
    }
}