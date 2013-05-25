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
        public bool AgregarInstructor(string tbcedula, string tbprimer_nombre, string tbprimer_apellido, long tbtelefono_local, string tbciudad, string tbsegundo_nombre, string tbsegundo_apellido, long tbtelefono_celular, string tbdireccion, string tbemail, string tbpersona_contacto, long tbtelefono, DateTime calendar, string sexo)
        {
            SQLServerInstructor objDataBase = new SQLServerInstructor();
            try
            {
                if (objDataBase.ExisteInstructor(tbcedula))
                    return false;
                else
                    return objDataBase.insertarInstructor(tbcedula, tbprimer_nombre, tbprimer_apellido, tbtelefono_local, tbciudad, tbsegundo_nombre, tbsegundo_apellido, tbtelefono_celular, tbdireccion, tbemail, tbpersona_contacto, tbtelefono, calendar, sexo);
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
        public bool EliminarInstructor(string cedula)
        {
            SQLServerInstructor instructor = new SQLServerInstructor();
            try
            {
                if (instructor.EliminarInstructor(cedula))
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


        #region ActualizarInstructor
        public bool ActualizarInstructor(Entidades.Instructor.Instructor instructor, String CIinicial)
        {

            SQLServerHorario objDataBase = new SQLServerHorario();
            bool exito = false;
            try
            {
                int id = objDataBase.BuscarId(CIinicial);

                SQLServerInstructor objDataBase2 = new SQLServerInstructor();
                objDataBase2.ActualizarIntructor(instructor, id);
                exito = true;

            }

            catch (InstructorBDException e)
            {
                throw new InstructorException("No se pudo actualizar el instructor: " + e.Message, e);
            }
            return exito;
        }
        #endregion ActualizarInstructor




    }

}