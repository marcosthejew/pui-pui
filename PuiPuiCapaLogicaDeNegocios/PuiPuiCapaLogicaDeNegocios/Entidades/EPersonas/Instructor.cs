using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;
using PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas
{
    public class Instructor : APersona, IEvaluable, IReservable
    {

        #region Atributos

        private List<Horario> _horario;

        #endregion

        #region Getter & Setter

        public List<Horario> Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        #endregion

        #region Constructores

        public Instructor()
        {
            _horario = new List<Horario>();
        }

        public Instructor(int id):base(id)
        {
            _horario = new List<Horario>();
        }

        public Instructor(int cedula, string nombre1, string nombre2, string apellido1, string apellido2,
         string genero, DateTime fechaNacimiento, string ciudad, string direccion, string correo, string contacto,
         string telfContacto, List<Horario> horario)
            : base(cedula, nombre1, nombre2, apellido1, apellido2, genero, fechaNacimiento, ciudad, direccion, correo,
             contacto, telfContacto)
        {
            _horario = horario;
        }

        #endregion

        #region Metodos

        void IEvaluable.evaluar(int calificacion)
        {
        }

        void IReservable.reservar(EHorario.Horario horario)
        {
        }

        #endregion

    }
}