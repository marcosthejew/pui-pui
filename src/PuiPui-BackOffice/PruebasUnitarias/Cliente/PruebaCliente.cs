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


        [Test]
        public void AgregarPersona()
        {
            //string fecha1 = DateTime.Now.ToString();
            //DateTime fecha2 = Convert.ToDateTime(fecha1);

            SQLServerPersona sqlPersona = new SQLServerPersona();
            LogicaPersona persona = new LogicaPersona();
            Persona miPersona = new Persona();
            Persona personita = new Persona();

            miPersona.CedulaPersona = 16204421;
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


            personita = persona.AgregoCliente(miPersona);
            // sqlPersona.AgregarCliente(miPersona);

            Assert.AreEqual(personita, miPersona);
            Assert.AreEqual(personita, "exito");


        }
    }
}