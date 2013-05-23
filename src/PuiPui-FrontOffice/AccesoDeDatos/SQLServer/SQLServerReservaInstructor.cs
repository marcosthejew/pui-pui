using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerReservaInstructor
    {

        public Boolean agregarReservaInstructor(int iDCliente, int iDInstructor, DateTime FechaReserva, DateTime FechaInicio, DateTime FechaFin)
        {
            return true;
        }

        public Boolean modificarReservaInstructor(string CedulaCliente, string CedulaInstructor, DateTime FechaInicio, DateTime FechaFin, string NuevaCedulaInstructor, DateTime NuevaFechaInicio, DateTime NuevaFechaFin)
        {
            return true;
        }

        public SqlDataReader consultarReservaInstructorPorCliente(string CedulaCliente)
        {
            return null;
        }

        public SqlDataReader consultarReservaInstructorPorInstructor(string CedulaInstructor)
        {
            return null;
        }

        public SqlDataReader consultarReservaInstructorTodas()
        {
            return null;
        }

        public Boolean chequearDisponibilidad(int CedulaInstructor, DateTime FechaInicio, DateTime FechaFin)
        {
            return true;
        }
    }
}