using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas
{
    public class APersona : AEntidad
    {

        #region Atributos

        protected string _cedula;
        protected string _nombre1;
        protected string _nombre2;
        protected string _apellido1;
        protected string _apellido2;
        protected string _sexo;
        protected DateTime _fechaNac;
        protected DateTime _fechaIngreso;
        protected string _entidadFederal;
        protected string _ciudad;
        protected string _direccion;
        protected string _telefonoLocal;
        protected string _telefonoCelular;
        protected string _email;

        #endregion

        #region Encapsulamiento

        public string CedulaPersona
        {
            get { return _cedula; }
            set { _cedula = value; }
        }
        public string NombrePersona1
        {
            get { return _nombre1; }
            set { _nombre1 = value; }
        }
        public string NombrePersona2
        {
            get { return _nombre2; }
            set { _nombre2 = value; }
        }
        public string ApellidoPersona1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }
        public string ApellidoPersona2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }
        public string GeneroPersona
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public DateTime FechaNacimientoPersona
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }
        public DateTime FechaIngresoPersona
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }
        public string CiudadPersona
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
        public string DireccionPersona
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string TelefonoLocalPersona
        {
            get { return _telefonoLocal; }
            set { _telefonoLocal = value; }
        }
        public string TelefonoCelularPersona
        {
            get { return _telefonoCelular; }
            set { _telefonoCelular = value; }
        }
        public string CorreoPersona
        {
            get { return _email; }
            set { _email = value; }
        }
        public string EstadoPersona
        {
            get { return _entidadFederal; }
            set { _entidadFederal = value; }
        }

        #endregion

    }
}