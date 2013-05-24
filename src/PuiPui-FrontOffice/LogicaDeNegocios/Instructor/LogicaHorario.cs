using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;
using PuiPui_FrontOffice.Entidades;

namespace PuiPui_FrontOffice.LogicaDeNegocios.Instructor
{
    public class LogicaHorario
    {
        public void agregarHorario(Horario horario, string cedula)
        {
            SQLServerHorario sqlhorario = new SQLServerHorario();
            int a = sqlhorario.BuscarId(cedula);
            sqlhorario.agregarHorario(horario, a);

        }
    
    }
}