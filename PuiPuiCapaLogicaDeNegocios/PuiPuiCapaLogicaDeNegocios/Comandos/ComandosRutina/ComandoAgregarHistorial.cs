using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoAgregarHistorial : AComando<bool>
    {
        int repeticion;
        string duracion;
        int idCliente;
        int idEjercicio;
        int idRutina;


        /// <summary>
        /// Esta clase tiene como finalidad agregar rutinas nuevas
        /// </summary>
        public ComandoAgregarHistorial(int _repeticion, string _duracion, int _idCliente, int _idRutina, int _idEjercicio){
            this.repeticion = _repeticion;
            this.duracion = _duracion;
            this.idCliente = _idCliente;
            this.idEjercicio = _idEjercicio;
            this.idRutina = _idRutina;

        }

        public override bool Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();
                return rutinaDAO.AgregarHistorialRutina(duracion, repeticion, idCliente, idRutina, idEjercicio);


            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}