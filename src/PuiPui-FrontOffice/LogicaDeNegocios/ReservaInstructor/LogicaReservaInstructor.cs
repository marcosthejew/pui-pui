using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntidadReservaInstructor = PuiPui_FrontOffice.Entidades.ReservaInstructor;
using EntidadCliente = PuiPui_FrontOffice.Entidades.Cliente;
using EntidadInstructor = PuiPui_FrontOffice.Entidades.Instructor;
using PuiPui_FrontOffice.Entidades;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;
using System.Data.SqlClient;

namespace PuiPui_FrontOffice.LogicaDeNegocios.ReservaInstructor
{
    public class LogicaReservaInstructor
    {

        public void agregarReservaInstructor(string login, int iDInstructor, DateTime fechaInicio, DateTime fechaFin)
        {
            SQLServerReservaInstructor sQLServerReservaInstructor = new SQLServerReservaInstructor();
            try
            {
                if (sQLServerReservaInstructor.chequearDisponibilidad(iDInstructor, fechaInicio, fechaFin))
                {
                    SQLServerPersona sQLServerPersona = new SQLServerPersona();
                    EntidadCliente.Clientes cliente = (EntidadCliente.Clientes)sQLServerPersona.ConsultarPersonaPorLogin(login);
                    EntidadInstructor.Instructor instructor = (EntidadInstructor.Instructor)sQLServerPersona.ConsultarDetallePersona(iDInstructor);
                    EntidadReservaInstructor.ReservaInstructor ReservaInstructor = new EntidadReservaInstructor.ReservaInstructor(instructor, cliente, fechaInicio, fechaFin);

                    sQLServerReservaInstructor.agregarReservaInstructor(ReservaInstructor.Cliente.IdPersona, ReservaInstructor.Instructor.IdPersona,
                                                                        ReservaInstructor.FechaReservacion, ReservaInstructor.FechaInicio, ReservaInstructor.FechaFin);
                }
                else
                {
                    //lanzar excepcion "No hay disponibilidad"
                }
            }
            catch
            {
                //lanzar excepcion "Error en la comunicacion, intente mas tarde"
                //lanzar excepcion "No se pudo hacer la Reservacion"
            }
        }

        public List<EntidadReservaInstructor.ReservaInstructor> consultarReservaInstructor(string login)
        {
            SQLServerReservaInstructor sQLServerReservaInstructor = new SQLServerReservaInstructor();
            SQLServerPersona sQLServerPersona = new SQLServerPersona();
            List<EntidadReservaInstructor.ReservaInstructor> listaReservasInstructor = new List<EntidadReservaInstructor.ReservaInstructor>();
            SqlDataReader _dr;
            EntidadReservaInstructor.ReservaInstructor reservaInstructor;
            EntidadCliente.Clientes cliente;
            EntidadInstructor.Instructor instructor;

            try
            {

                _dr = sQLServerReservaInstructor.consultarReservaInstructorTodas();
                cliente = (EntidadCliente.Clientes)sQLServerPersona.ConsultarPersonaPorLogin(login);

                while (_dr.Read())
                {
                    instructor = (EntidadInstructor.Instructor)sQLServerPersona.ConsultarDetallePersona((int)_dr.GetValue(5));
                    reservaInstructor = new EntidadReservaInstructor.ReservaInstructor((string)_dr.GetValue(4), instructor, cliente,
                                                                                       (DateTime)_dr.GetValue(2), (DateTime)_dr.GetValue(3));

                    listaReservasInstructor.Add(reservaInstructor);
                }

            }
            catch
            {
                //lanzar excepcion "Error en la comunicacion, intente mas tarde"
                //lanzar excepcion "No se pudo hacer la Reservacion"
            }

            return listaReservasInstructor;
        }

        public void modificarReservaInstructor(EntidadReservaInstructor.ReservaInstructor ReservaInstructor, DateTime NuevaFechaInicio, DateTime NuevaFechaFin, string NuevaCedulaInstructor)
        {
            //Modifica en la base de datos y en la memoria de la aplicacion

        }

        public void eliminarReservaInstructor(string CedulaCliente, string CedulaInstructor, DateTime FechaInicio, DateTime FechaFin)
        {

        }

        public void consultarReservaInstructor(string CedulaCliente, string CedulaInstructor)
        {

        }
    }
}