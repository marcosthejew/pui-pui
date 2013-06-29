using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    /// <summary>
    /// Clase que contiene el comando para modificar salones.
    /// </summary>
    public class ComandoModificarSalon : AComando<bool>
    {
        private int _id;
        private AEntidad _salon;
         /// <summary>
         /// Constructor de la clase que recibe el id del salon a modificar y el nuevo objeto que posee los atributos a modificar
         /// </summary>
         /// <param name="id"></param>
         /// <param name="salon"></param>
        public ComandoModificarSalon(int id, Salon salon)
        {
            _id = id;
            _salon = salon;
        }

        /// <summary>
        /// Ejecuta el comando y retorna true en caso de haber modificado el salon y falso en caso de no haberlo hecho.
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {
            bool modifico = false;
            ISalonDAO salonDao= (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            salonDao = new DAOs.DAOsClases.SalonSQLServerDAO();
            modifico = salonDao.Modificar(_id, _salon);
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora
            ("el usuario **** accedio al comando consultar modificar salon");
            return (modifico);

        }
    }
}