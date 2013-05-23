using System;
using System.Collections.Generic;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.Entidades.Instructor;
using PuiPui_FrontOffice.Entidades.Excepciones;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.ReservaInstructor
{
    public class ReservaInstructor
    {
        #region Atributos

        private Instructor.Instructor _instructor;
        private Cliente.Clientes _cliente;
        private DateTime _fechaReservacion;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private string _status;

        #endregion


        #region Getters&Setters
        public Instructor.Instructor Instructor
        {
            get { return _instructor; }
            set
            {
                if (value == null)
                {
                    throw new ExcepcionReservaInstructorSinInstructor("Debe especificarse un instructor al momento de reservar un instructor");
                }
                else
                {
                    _instructor = value;
                }
            }
        }

        public Cliente.Clientes Cliente
        {
            get { return _cliente; }
            set
            {
                if (value == null)
                {
                    throw new ExcepcionReservaInstructorSinCliente("Debe especificarse un cliente al momento de reservar un instructor");
                }
                else
                {
                    _cliente = value;
                }
            }
        }

        public DateTime FechaReservacion
        {
            get { return _fechaReservacion; }
            set { _fechaReservacion = value; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set
            {
                if (value == null)
                {
                    throw new ExcepcionReservaInstructorSinFechaInicio("Debe especificarse una fecha de inicio para la reservacion del instructor");
                }
                else if (value < DateTime.Now)
                {
                    throw new ExcepcionReservaInstructorFechaInicioPasada("La fecha de inicio de una reservacion debe ser una fecha futura");
                }
                else
                {
                    if ((FechaFin != null) && (FechaFin < value))
                    {
                        throw new ExcepcionReservaInstructorFechaInicioPosteriorAFutura("La fecha de inicio no puede ser posterior a la fecha de fin");
                    }
                    else
                    {
                        _fechaInicio = value;
                    }
                }
            }
        }

        public DateTime FechaFin
        {
            get { return _fechaFin; }
            set
            {
                if (value == null)
                {
                    throw new ExcepcionReservaInstructorSinFechaFin("Debe especificarse una fecha de fin para la reservacion del instructor");
                }
                else
                {
                    if ((FechaInicio != null) && (FechaInicio > value))
                    {
                        throw new ExcepcionReservaInstructorFechaInicioPosteriorAFutura("La fecha de fin no puede ser anterior a la fecha de inicio");
                    }
                    else
                    {
                        _fechaFin = value;
                    }
                }
            }
        }

        public string Status
        {
            get { return _status; }
            set
            {
                if ((value.Equals("completada")) || (value.Equals("cancelada")) || (value.Equals("espera")))
                {
                    _status = value;
                }
                else
                {
                    throw new ExcepcionReservaInstructorStatusInvalido("El status especificado para la reservacion es invalido." + 
                                                                          "El status debe ser 'completada', 'cancelada' o 'espera'");
                }
            }
        }

        #endregion


        #region Constructores

        public ReservaInstructor(string status, Instructor.Instructor instructor, Cliente.Clientes cliente, DateTime fechaInicio, DateTime fechaFin)
        {
            Instructor = instructor;
            Cliente = cliente;
            FechaReservacion = DateTime.Now;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Status = status;
        }

        public ReservaInstructor(Instructor.Instructor instructor, Cliente.Clientes cliente, DateTime fechaInicio, DateTime fechaFin)
        {
            Instructor = instructor;
            Cliente = cliente;
            FechaReservacion = DateTime.Now;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Status = "espera";
        }

        #endregion


        public bool Equals(ReservaInstructor reservaInstructor)
        {
            if (reservaInstructor == null)
            {
                return false;
            }
            else
            {
                return (Instructor.CedulaPersona.Equals(reservaInstructor.Instructor.CedulaPersona)) &&
                       (Cliente.CedulaPersona.Equals(reservaInstructor.Cliente.CedulaPersona)) &&
                       (FechaReservacion.Equals(reservaInstructor.FechaReservacion)) &&
                       (FechaInicio.Equals(reservaInstructor.FechaInicio)) &&
                       (FechaFin.Equals(reservaInstructor.FechaFin));
            }
        }

        public bool Choca(ReservaInstructor reservaInstructor)
        {
            if (reservaInstructor == null)
            {
                return true;
            }
            else
            {
                if ((FechaFin < reservaInstructor.FechaInicio) || (FechaInicio > reservaInstructor.FechaFin))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}