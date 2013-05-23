using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.Entidades;
using PuiPui_FrontOffice.Entidades.Clase;
using PuiPui_FrontOffice.Entidades.ReservarClase;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;

namespace PuiPui_FrontOffice.LogicaDeNegocios.ReservarClase
{
    public class LogicaReservarClase
    {
        #region Clases Ofertadas
        public List<Clase> ListarClases()
        {

            List<Clase> miListaClase = new List<Clase>();
            SQLServerReservarClase objDataBase = new SQLServerReservarClase();
            miListaClase = objDataBase.ListarClasesDisponibles();
            return miListaClase;
        }
        #endregion

        #region Buscar Horarios Disponibles

        public List<HorarioReservacionClase> BuscarHorariosDisponibles(int idClases)
        {
            {

                List<HorarioReservacionClase> miListaHorario = new List<HorarioReservacionClase>();
                SQLServerReservarClase objDataBase = new SQLServerReservarClase();
                miListaHorario = objDataBase.ListarHorariosDisponibles(idClases);
                return miListaHorario;
            }
        }

        #endregion

        #region Listar Instructores Disponibles

        public List<InstructorClase> ListarInstructoresDisponibles(int idHorario)
        {
            {

                List<InstructorClase> miListaInstructor = new List<InstructorClase>();
                SQLServerReservarClase objDataBase = new SQLServerReservarClase();
                miListaInstructor = objDataBase.ListarInstructoresDisponibles(idHorario);
                return miListaInstructor;
            }
        }

        #endregion
    }
}