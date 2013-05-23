using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.Entidades;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.Entidades.Instructor;
using PuiPui_FrontOffice.Entidades.EEvaluacionInstructor;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;
using System.Data.SqlClient;

namespace PuiPui_FrontOffice.LogicaDeNegocios.EvaluacionInstructor
{
    public class LogicaEvaluacionInstructor
    {

        SQLServerEvaluacionInstructor _datosEvaluaciones;
        List<LogicaEvaluacionInstructor> _evaluaciones;
        private SqlDataReader _dr;
        EEvaluacionInstructor _evaluacion;
        List<EEvaluacionInstructor> _listaEvaluacion;

        public LogicaEvaluacionInstructor()
        {
            _datosEvaluaciones = new SQLServerEvaluacionInstructor();
            _evaluaciones = new List<LogicaEvaluacionInstructor>();
            _listaEvaluacion = new List<EEvaluacionInstructor>();
            //_dr = new SqlDataReader();
        }

        #region Consultar Todas la Evaluaciones
        //Metodo para consultar todas las evaluaciones
        public List<EEvaluacionInstructor> ConsultarEvaluacion()
        {
            _dr = _datosEvaluaciones.ConsultarEvaluaciones();

            while (_dr.Read())
            {

                _evaluacion = new EEvaluacionInstructor();

                _evaluacion.Instructor.IdPersona = (int)_dr.GetValue(0);
                _evaluacion.Instructor.NombrePersona1 = _dr.GetValue(1).ToString();
                _evaluacion.Instructor.NombrePersona2 = _dr.GetValue(2).ToString();
                _evaluacion.Instructor.ApellidoPersona1 = _dr.GetValue(3).ToString();
                _evaluacion.Instructor.ApellidoPersona2 = _dr.GetValue(4).ToString();
                _evaluacion.Instructor.GeneroPersona = _dr.GetValue(5).ToString();
                _evaluacion.Instructor.FechaNacimientoPersona = (DateTime)_dr.GetValue(6);
                _evaluacion.Instructor.FechaIngresoPersona = (DateTime)_dr.GetValue(7);
                _evaluacion.Instructor.CiudadPersona = _dr.GetValue(8).ToString();
                _evaluacion.Instructor.DireccionPersona = _dr.GetValue(9).ToString();
                _evaluacion.Instructor.TelefonoLocalPersona = _dr.GetValue(10).ToString();
                _evaluacion.Instructor.TelefonoCelularPersona = _dr.GetValue(11).ToString();
                _evaluacion.Instructor.CorreoPersona = _dr.GetValue(12).ToString();
                _evaluacion.Instructor.ContactoNombrePersona = _dr.GetValue(13).ToString();
                _evaluacion.Instructor.ContactoTelefonoPersona = _dr.GetValue(14).ToString();
                _evaluacion.Instructor.EstadoPersona = _dr.GetValue(15).ToString();
                _evaluacion.Instructor.CedulaPersona = Convert.ToInt32(_dr.GetValue(16));

                _evaluacion.IdEvaluacion = (int)_dr.GetValue(17);
                _evaluacion.Fecha = (DateTime)_dr.GetValue(18);
                _evaluacion.Calificacion = (int)_dr.GetValue(19);
                if (_dr.GetValue(20) is DBNull)
                    _evaluacion.IdClaseSalon = 0;
                else
                    _evaluacion.IdClaseSalon = (int)_dr.GetValue(20);
                if (_dr.GetValue(21) is DBNull)
                    _evaluacion.IdCliente = 0;
                else
                    _evaluacion.IdCliente = (int)_dr.GetValue(21);
                _evaluacion.IdInstructor =(int)_dr.GetValue(22);

                _listaEvaluacion.Add(_evaluacion);
            }

            //_evaluaciones = _datosEvaluaciones.ConsultarEvaluaciones();

            return _listaEvaluacion;
        }
        #endregion

        public EEvaluacionInstructor ObtenerEvaluacion(DateTime fecha, int calificacion, int idCliente, int idInstructor)
        {
            EEvaluacionInstructor evaluacion = new EEvaluacionInstructor();

            evaluacion.Fecha = fecha;
            evaluacion.Calificacion = calificacion;
            evaluacion.IdCliente = idCliente;
            evaluacion.IdInstructor = idInstructor;

            return evaluacion;
        }

        #region Agregar Evaluacion
        public Boolean AgregarEvaluacion(EEvaluacionInstructor evaluacion)
        {
            Boolean agrego = false;
            agrego = _datosEvaluaciones.AgregarEvaluacion(evaluacion.Fecha, evaluacion.Calificacion, evaluacion.IdCliente, evaluacion.IdInstructor);
            return agrego;
        }
        #endregion

        #region Modificar Evaluacion
        public Boolean ModificarEvaluacion(EEvaluacionInstructor evaluacion)
        {
            Boolean modifico = false;
            modifico = _datosEvaluaciones.ModificarEvaluacion(evaluacion.Calificacion, evaluacion.IdCliente, evaluacion.IdInstructor,evaluacion.IdEvaluacion);
            return modifico;
        }
        #endregion

        //Metodo para consultar todas las evaluaciones de un cliente
        public List<Evaluacion> ConsultarEvaluacion(Clientes cliente)
        {
            List<Evaluacion> evaluaciones = null;
            
            return evaluaciones;
        }

        //Metodo para consultar las evaluaciones por cliente e instructor
        public List<Evaluacion> ConsultarEvaluacion(Clientes cliente, Instructor instructor)
        {
            List<Evaluacion> evaluaciones = null;

            return evaluaciones;
        }

        //Metodo para consultar todas las evaluaciones de un instructor
        public List<Evaluacion> ConsultarEvaluacion(Instructor instructor)
        {
            List<Evaluacion> evaluaciones = null;

            return evaluaciones;
        }
    }
}