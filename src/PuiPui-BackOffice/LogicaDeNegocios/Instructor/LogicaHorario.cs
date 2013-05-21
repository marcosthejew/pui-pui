using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades;

namespace PuiPui_BackOffice.LogicaDeNegocios.Instructor
{
    public class LogicaHorario
    {


            public void agregarHorario (Horario horario,string cedula)
            {
                SQLServerHorario sqlhorario = new SQLServerHorario();
                int a=sqlhorario.BuscarId(cedula);
                sqlhorario.agregarHorario(horario,a);

            }
    
    
    
    
    
    
    }

    
}