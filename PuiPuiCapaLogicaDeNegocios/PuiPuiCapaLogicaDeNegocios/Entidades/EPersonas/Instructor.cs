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

        public Instructor(int id)
        {
            _id = id;
            _horario = new List<Horario>();
        }

        public Instructor(string cedula, string nombre1, string nombre2, string apellido1, string apellido2,
         string genero, DateTime fechaNacimiento,DateTime fechaIngreso,string estado, string ciudad, string direccion,
         string correo, string tlfLocal, string telfCelular, List<Horario> horario)
            
        {
            _cedula = cedula;
            _nombre1 = nombre1;
            _nombre2 = nombre2;
            _apellido1 = apellido1;
            _apellido2 = apellido2;
            _sexo = genero;
            _fechaNac = fechaNacimiento;
            _fechaIngreso = fechaIngreso;
            _entidadFederal = estado;
            _ciudad = ciudad;
            _direccion = direccion;
            _telefonoLocal = tlfLocal;
            _telefonoCelular = telfCelular;
            _email = correo;
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