using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using NUnit.Framework;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_FrontOffice.PruebasUnitarias.Client
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
        public void TestAccesoPersona()
        {

            miAcceso.Login = "karla";
            miAcceso.Password = "1234";

            resultado = logPersona.LoginCorrecto(miAcceso.Login, miAcceso.Password);
                
            Assert.AreEqual(correcto, resultado);
        }


        //arreglar
        [Test]
        public void TestConsultarPersonaPorLogin()
        {
            miPersona.CedulaPersona = Convert.ToInt32("19887778");
            miPersona.NombrePersona1 = "Sandra";
            miPersona.NombrePersona2 = "Lissete                                           ";
            miPersona.ApellidoPersona1 = "Villamizar";
            miPersona.ApellidoPersona2 = "Meza                                              ";
            miPersona.GeneroPersona = "Femenino";
            miPersona.FechaNacimientoPersona = Convert.ToDateTime("1987-04-03");
            miPersona.FechaIngresoPersona = Convert.ToDateTime("2013-05-14");
            miPersona.CiudadPersona = "Caracas";
            miPersona.DireccionPersona = "El Junquito, Km 4";
            miPersona.TelefonoLocalPersona = "021298766678";
            miPersona.TelefonoCelularPersona = "04169876678";
            miPersona.ContactoNombrePersona = "Iliana Pita";
            miPersona.ContactoTelefonoPersona = "04129876543";
            miPersona.CorreoPersona = "sandravillamizar87@gmail.com";
            miPersona.EstadoPersona = "Activo";
            miPersona.LoginPersona = "sandra";
            miPersona.PasswordPersona = "1234";
            miPersona.TipoPersona = "Cliente";

            personita = logPersona.ConsultarPersonaPorLogin("Sandra");

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

        [Test]
        public void TestModificarPersona()
        {
            miPersona.IdPersona = 7;
            miPersona.CedulaPersona = Convert.ToInt32("18777876");
            miPersona.NombrePersona1 = "Karla";
            miPersona.NombrePersona2 = "Andreina                                          ";
            miPersona.ApellidoPersona1 = "Rodriguez";
            miPersona.ApellidoPersona2 = "Ramirez                                              ";
            miPersona.GeneroPersona = "Fsemenino";
            miPersona.FechaNacimientoPersona = Convert.ToDateTime("1987-09-30");
            miPersona.FechaIngresoPersona = Convert.ToDateTime("2013-05-14");
            miPersona.CiudadPersona = "San Antonio";
            miPersona.DireccionPersona = "Lider";
            miPersona.TelefonoLocalPersona = "02123455565";
            miPersona.TelefonoCelularPersona = "04167658765";
            miPersona.ContactoTelefonoPersona = "04168328972";
            miPersona.ContactoNombrePersona = "Patricia Tamayo";
            miPersona.CorreoPersona = "karlarogriguez@gmail.com";
            miPersona.EstadoPersona = "Activo";
            miPersona.LoginPersona = "karla";
            miPersona.PasswordPersona = "1234";
            miPersona.TipoPersona = "Cliente";


            resultado = sqlPersona.ModificarPersona(miPersona);

            Assert.AreEqual(correcto, resultado);

        }

    }
}