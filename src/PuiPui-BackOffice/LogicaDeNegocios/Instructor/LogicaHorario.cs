using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;

namespace PuiPui_BackOffice.LogicaDeNegocios.Instructor
{
    public class LogicaHorario
    {
        #region AgregarHorario
        public void agregarHorario (Horario horario,string cedula)
            {
                SQLServerHorario sqlhorario = new SQLServerHorario();
                try
                {
                    int a = sqlhorario.BuscarId(cedula);
                    sqlhorario.agregarHorario(horario, a);
                }
                catch (HorarioBDException e)
                {
                    throw new HorarioException("No se pudo agregar el horario: " + e.Message, e);
                }

            }
        #endregion AgregarHorario
        
    }

    
}