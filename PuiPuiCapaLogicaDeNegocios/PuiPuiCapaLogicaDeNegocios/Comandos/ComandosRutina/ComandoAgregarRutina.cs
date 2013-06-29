using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoAgregarRutina : AComando<bool>
    {

        string nombre;
        string descripcion;

        /// <summary>
        /// Esta clase tiene como finalidad agregar rutinas nuevas
        /// </summary>
        public ComandoAgregarRutina(string _nombre, string _descripcion)
        {
            this.nombre = _nombre;
            this.descripcion = _descripcion;
        }

        public override bool Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();
                return rutinaDAO.AgregarRutina(nombre, descripcion);


            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}