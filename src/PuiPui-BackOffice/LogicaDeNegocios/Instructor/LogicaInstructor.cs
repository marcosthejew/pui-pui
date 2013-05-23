using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;

namespace PuiPui_BackOffice.LogicaDeNegocios.Instructor
{
    public class LogicaInstructor
    {

        #region AgregarInstructor
        public bool AgregarInstructor(string tb1, string tb2, string tb3, int tb4, string tb5, string tb6, string tb7, int tb8, string tb9, string tb10, string tb11, int tb12, DateTime calendar, string cb)
        {
            SQLServerInstructor objDataBase = new SQLServerInstructor();
            try
            {
                if (objDataBase.ExisteInstructor(tb1))
                    return false;
                else
                    return objDataBase.insertarInstructor(tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9, tb10, tb11, tb12, calendar, cb);
            }
            catch (InstructorBDException e)
            {
                throw new InstructorException("No se pudo agregar el instructor: " + e.Message, e);
            }
        }
        #endregion AgregarInstructor

        #region ConsultarTodosInstructores
        public List<Entidades.Instructor.Instructor> ConsultarTodosInstructores()
        {
            SQLServerInstructor objDataBase = new SQLServerInstructor();
            try
            {
                if (objDataBase.ConsultarInstructores() != null)
                {
                    return objDataBase.ConsultarInstructores();
                }
                return null;
            }
            catch (InstructorBDException e)
            {
                throw new InstructorException("No se pudo consultar todos los instructores: " + e.Message, e);
            }
        }
        #endregion ConsultarTodosInstructores

        #region ConsultarInstructor
        public Entidades.Instructor.Instructor ConsultarInstructor(string cedula)
        {
            SQLServerInstructor objDataBase = new SQLServerInstructor();
            try
            {
                if (objDataBase.ConsultarIntructor(cedula) != null)
                {
                    return objDataBase.ConsultarIntructor(cedula);
                }
                return null;
            }
            catch (InstructorBDException e)
            {
                throw new InstructorException("No se pudo consultar el instructor: " + e.Message, e);
            }
        }
        #endregion ConsultarInstructor

        #region EliminarInstructor
        public bool EliminarInstructor(string a)
        {
            SQLServerInstructor instructor = new SQLServerInstructor();
            try
            {
                if (instructor.TieneClase(a))
                    return false;
                else if (instructor.TieneCliente(a))
                    return false;
                else if (instructor.EliminarInstructor(a))
                    return true;

                 return false;
            }
            catch (InstructorBDException e)
            {
                throw new InstructorException("No se pudo eliminar el instructor: " + e.Message, e);
            }
        }
        #endregion EliminarInstructor

        #region ConsultarTodosInstructoresActivos
        public List<Entidades.Instructor.Instructor> ConsultarTodosInstructoresActivos()
        {
            SQLServerInstructor objDataBase = new SQLServerInstructor();
            try
            {
                if (objDataBase.ConsultarInstructores() != null)
                {
                    return objDataBase.ConsultarInstructoresActivos();
                }
                return null;
            }
            catch (InstructorBDException e)
            {
                throw new InstructorException("No se pudo consultar todos los instructores: " + e.Message, e);
            }
        }
        #endregion ConsultarTodosInstructoresActivos
    }
}