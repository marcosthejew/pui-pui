using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.Entidades.Cliente
{
    public class Persona
        {

            #region Atributos

            private int _idPersona;
            private int _cedulaPersona;
            private string _nombrePersona1;
            private string _nombrePersona2;
            private string _apellidoPersona1;
            private string _apellidoPersona2;
            private string _generoPersona;
            private DateTime _fechaNacimientoPersona;
            private DateTime _fechaIngresoPersona;
            private string _ciudadPersona;
            private string _DireccionPersona;
            private string _telefonoLocalPersona;
            private string _telefonoCelularPersona;
            private string _correoPersona;
            private string _contactoNombrePersona;
            private string _contactoTelefonoPersona;
            private string _estadoPersona;
            private string _loginPersona;
            private string _passwordPersona;
            private string _tipoPersona;

            #endregion

            #region Encapsulamiento

            public int IdPersona
            {
                get { return _idPersona; }
                set { _idPersona = value; }
            }
            public int CedulaPersona
            {
                get { return _cedulaPersona; }
                set { _cedulaPersona = value; }
            }
            public string NombrePersona1
            {
                get { return _nombrePersona1; }
                set { _nombrePersona1 = value; }
            }
            public string NombrePersona2
            {
                get { return _nombrePersona2; }
                set { _nombrePersona2 = value; }
            }
            public string ApellidoPersona1
            {
                get { return _apellidoPersona1; }
                set { _apellidoPersona1 = value; }
            }
            public string ApellidoPersona2
            {
                get { return _apellidoPersona2; }
                set { _apellidoPersona2 = value; }
            }
            public string GeneroPersona
            {
                get { return _generoPersona; }
                set { _generoPersona = value; }
            }
            public DateTime FechaNacimientoPersona
            {
                get { return _fechaNacimientoPersona; }
                set { _fechaNacimientoPersona = value; }
            }
            public DateTime FechaIngresoPersona
            {
                get { return _fechaIngresoPersona; }
                set { _fechaIngresoPersona = value; }
            }
            public string CiudadPersona
            {
                get { return _ciudadPersona; }
                set { _ciudadPersona = value; }
            }
            public string DireccionPersona
            {
                get { return _DireccionPersona; }
                set { _DireccionPersona = value; }
            }
            public string TelefonoLocalPersona
            {
                get { return _telefonoLocalPersona; }
                set { _telefonoLocalPersona = value; }
            }
            public string TelefonoCelularPersona
            {
                get { return _telefonoCelularPersona; }
                set { _telefonoCelularPersona = value; }
            }
            public string CorreoPersona
            {
                get { return _correoPersona; }
                set { _correoPersona = value; }
            }
            public string ContactoNombrePersona
            {
                get { return _contactoNombrePersona; }
                set { _contactoNombrePersona = value; }
            }
            public string ContactoTelefonoPersona
            {
                get { return _contactoTelefonoPersona; }
                set { _contactoTelefonoPersona = value; }
            }
            public string EstadoPersona
            {
                get { return _estadoPersona; }
                set { _estadoPersona = value; }
            }
            public string LoginPersona
            {
                get { return _loginPersona; }
                set { _loginPersona = value; }
            }
            public string PasswordPersona
            {
                get { return _passwordPersona; }
                set { _passwordPersona = value; }
            }
            public string TipoPersona
            {
                get { return _tipoPersona; }
                set { _tipoPersona = value; }
            }

            #endregion
            #region Construccion

            public Persona()
            {

            }

            #endregion

        }
    }
