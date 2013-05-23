using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using NUnit.Framework;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Cliente;




namespace PuiPui_BackOffice.PruebasUnitarias.Cliente
{
    [TestFixture]
    public class PruebaCliente
    {
        LogicaPersona logPersona = new LogicaPersona();
        Persona miPersona = new Persona();
        Acceso miAcceso = new Acceso();
        Persona personita = new Persona();
        SQLServerPersona sqlPersona = new SQLServerPersona();
        bool correcto = true;
        bool resultado = false;


        [Test]
        public void TestAgregarPersona()
        {

            miPersona.CedulaPersona = Convert.ToInt32("16204421");
            miPersona.NombrePersona1 = "Luis";
            miPersona.NombrePersona2 = "Antonio";
            miPersona.ApellidoPersona1 = "Toro";
            miPersona.ApellidoPersona2 = "Vasquez";
            miPersona.GeneroPersona = "Masculino";
            miPersona.FechaNacimientoPersona = Convert.ToDateTime("2013-01-05");
            miPersona.FechaIngresoPersona = Convert.ToDateTime("2013-05-20");
            miPersona.CiudadPersona = "Caracas";
            miPersona.DireccionPersona = "San antonio de los altos";
            miPersona.TelefonoCelularPersona = "04242744173";
            miPersona.TelefonoLocalPersona = "02123729874";
            miPersona.CorreoPersona = "luistorous@gmail.com";
            miPersona.ContactoNombrePersona = "Angelica Toro";
            miPersona.ContactoTelefonoPersona = "04122842548";
            miPersona.EstadoPersona = "Activo";
            miPersona.LoginPersona = "arindhor";
            miPersona.PasswordPersona = "toto4001";
            miPersona.TipoPersona = "Cliente";


            personita = logPersona.AgregoCliente(miPersona);

            Assert.AreEqual(personita, miPersona);

        }

        [Test]
        public void TestAccesoPersona()
        {

            miAcceso.Login = "angelica";
            miAcceso.Password = "1234";

            resultado = logPersona.LoginCorrecto(miAcceso.Login, miAcceso.Password);

            Assert.AreEqual(correcto, resultado);
        }

        [Test]
        public void TestConsultarPorCedula()
        {
            string cedula = "19998098";
            List<Persona> listaPersona = new List<Persona>();

            listaPersona = logPersona.ConsultarPorCedula(cedula);

            Assert.AreEqual(listaPersona[0].CedulaPersona, Convert.ToInt32(cedula));

        }

        [Test]
        public void TestConsultarPorNombre()
        {
            string nombre = "Karla";

            List<Persona> listaPersona = new List<Persona>();

            listaPersona = logPersona.ConsultarPorNombre(nombre);

            Assert.AreEqual(listaPersona[0].NombrePersona1.TrimEnd(), nombre);
        }

        [Test]
        public void TestCambiarEstado()
        {
            miPersona.EstadoPersona = "Inactivo";
            miPersona.IdPersona = 1;


            resultado = sqlPersona.ActivarDesactivarPersona(miPersona);

            Assert.AreEqual(correcto, resultado);

        }

        //no funciona ahora
        [Test]
        public void TestModificarPersona()
        {
            miPersona.IdPersona = 1;
            miPersona.CedulaPersona = Convert.ToInt32("19887778");
            miPersona.NombrePersona1 = "Iliana";
            miPersona.NombrePersona2 = "Carolina";
            miPersona.ApellidoPersona1 = "Pita";
            miPersona.ApellidoPersona2 = "Perez";
            miPersona.GeneroPersona = "Femenino";
            miPersona.FechaNacimientoPersona = Convert.ToDateTime("1988-07-29");
            miPersona.FechaIngresoPersona = Convert.ToDateTime("2013-05-14");
            miPersona.CiudadPersona = "Caracas";
            miPersona.DireccionPersona = "Plaza venezuela";
            miPersona.TelefonoCelularPersona = "04149876543";
            miPersona.TelefonoLocalPersona = "02122345678";
            miPersona.CorreoPersona = "ilismile@gmail.com";
            miPersona.ContactoNombrePersona = "Leonardo Pita";
            miPersona.ContactoTelefonoPersona = "04128976543";
            miPersona.EstadoPersona = "Activo";
            miPersona.LoginPersona = "iliana";
            miPersona.PasswordPersona = "1234";
            miPersona.TipoPersona = "Cliente";


            resultado = sqlPersona.ModificarPersona(miPersona);

            Assert.AreEqual(correcto, resultado);

        }

        [Test]
        public void TestConsultaPersona()
        {

            miPersona.IdPersona = 2;
            miPersona.CedulaPersona = Convert.ToInt32("18777876");
            miPersona.NombrePersona1 = "Leonardo";
            miPersona.NombrePersona2 = "Jose                                              ";
            miPersona.ApellidoPersona1 = "Pita";
            miPersona.ApellidoPersona2 = "Perez                                             ";
            miPersona.GeneroPersona = "Masculino";
            miPersona.FechaNacimientoPersona = Convert.ToDateTime("1985-01-07");
            miPersona.FechaIngresoPersona = Convert.ToDateTime("2013-05-14");
            miPersona.CiudadPersona = "Caracas";
            miPersona.DireccionPersona = "La paz - Piso 5 Apto 5A";
            miPersona.TelefonoCelularPersona = "04128976543";
            miPersona.TelefonoLocalPersona = "02129876577";
            miPersona.ContactoTelefonoPersona = "04249876567";
            miPersona.ContactoNombrePersona = "Salvador Delgado";
            miPersona.CorreoPersona = "leopita@gmail.com";
            miPersona.EstadoPersona = "Activo";
            miPersona.LoginPersona = "leonardo";
            miPersona.PasswordPersona = "1234";
            miPersona.TipoPersona = "Cliente";



            personita = logPersona.ConsultarDetallePersona(2);

            Assert.AreEqual(miPersona.NombrePersona1, personita.NombrePersona1.TrimEnd());
            Assert.AreEqual(miPersona.NombrePersona2, personita.NombrePersona2);
            Assert.AreEqual(miPersona.ApellidoPersona1, personita.ApellidoPersona1.TrimEnd());
            Assert.AreEqual(miPersona.ApellidoPersona2, personita.ApellidoPersona2);
            Assert.AreEqual(miPersona.GeneroPersona, personita.GeneroPersona.TrimEnd());
            Assert.AreEqual(miPersona.FechaNacimientoPersona, personita.FechaNacimientoPersona);
            Assert.AreEqual(miPersona.FechaIngresoPersona, personita.FechaIngresoPersona);
            Assert.AreEqual(miPersona.CiudadPersona, personita.CiudadPersona.TrimEnd());
            Assert.AreEqual(miPersona.DireccionPersona, personita.DireccionPersona.TrimEnd());
            Assert.AreEqual(miPersona.TelefonoLocalPersona, personita.TelefonoLocalPersona.TrimEnd());
            Assert.AreEqual(miPersona.TelefonoCelularPersona, personita.TelefonoCelularPersona.TrimEnd());
            Assert.AreEqual(miPersona.ContactoNombrePersona, personita.ContactoNombrePersona.TrimEnd());
            Assert.AreEqual(miPersona.CorreoPersona, personita.CorreoPersona.TrimEnd());
            Assert.AreEqual(miPersona.EstadoPersona, personita.EstadoPersona.TrimEnd());
            Assert.AreEqual(miPersona.LoginPersona, personita.LoginPersona.TrimEnd());
            Assert.AreEqual(miPersona.PasswordPersona, personita.PasswordPersona.TrimEnd());
            Assert.AreEqual(miPersona.TipoPersona, personita.TipoPersona.TrimEnd());

        }

    }
}