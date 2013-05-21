using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades.Instructor;

namespace PuiPui_BackOffice.LogicaDeNegocios.Instructor
{
    public class LogicaInstructor
    {



        public bool AgregarInstructor(string tb1, string tb2, string tb3, int tb4, string tb5, string tb6, string tb7, int tb8, string tb9, string tb10, string tb11, int tb12, DateTime calendar, string cb)
        {

            SQLServerInstructor objDataBase = new SQLServerInstructor();
            if (objDataBase.ExisteInstructor(tb1))
            {
                return true;
            }
            else
            {
                return objDataBase.insertarInstructor(tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9, tb10, tb11, tb12, calendar, cb);
            }
        }




        public List<Entidades.Instructor.Instructor> ConsultarTodosInstructores()
        {
            SQLServerInstructor objDataBase = new SQLServerInstructor();
            if (objDataBase.ConsultarInstructores() != null)
            {
                return objDataBase.ConsultarInstructores();
            }
            return null;
        }




        public Entidades.Instructor.Instructor ConsultarInstructor(string cedula)
        {
            SQLServerInstructor objDataBase = new SQLServerInstructor();
            if (objDataBase.ConsultarIntructor(cedula) != null)
            {
                return objDataBase.ConsultarIntructor(cedula);
            }
            return null;
        }

    }
}