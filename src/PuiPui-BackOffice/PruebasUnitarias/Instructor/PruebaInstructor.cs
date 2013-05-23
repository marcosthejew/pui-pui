using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;

namespace PuiPui_BackOffice.PruebasUnitarias.Instructor
{
    [TestFixture]
    public class PruebaInstructor
    {
        [Test]
        public void TestAgregarInstructor()
        {
            LogicaInstructor objInstructor = new LogicaInstructor();

            string cedula = "19290620";
            string nombre1 = "Karem";
            string nombre2 = "Vanessa";
            string apellido1 = "Segura";
            string apellido2 = "Arocha";
            int telf = 9759730;
            string ciudad = "Caracas";
            int cel = 424149773;
            string direccion = "Colinas de Valle Arriba";
            string email = "karemsegura@gmail.com";
            string nombreEmergencia = "Laura Arocha";
            int telfEmergencia = 9757979;
            DateTime date = new DateTime(1990, 12, 11);
            string genero = "F";
            bool resp = objInstructor.AgregarInstructor(cedula, nombre1, apellido1, telf, ciudad, nombre2, apellido2, cel,
                direccion, email, nombreEmergencia, telfEmergencia, date, genero);
                
            Assert.AreEqual(true, resp);
        }

        [Test]
        public void TestConsultarInstructor()
        {
            LogicaInstructor objInstructor = new LogicaInstructor();

            Entidades.Instructor.Instructor instructor = new Entidades.Instructor.Instructor();
            instructor.CedulaPersona = 19290620;
            instructor.NombrePersona1 = "Karem";
            instructor.NombrePersona2 = "Vanessa";
            instructor.ApellidoPersona1 = "Segura";
            instructor.ApellidoPersona2 = "Arocha";
            instructor.TelefonoLocalPersona = "9759730";
            instructor.CiudadPersona = "Caracas";
            instructor.CedulaPersona = 424149773;
            instructor.DireccionPersona = "Colinas de Valle Arriba";
            instructor.CorreoPersona = "karemsegura@gmail.com";
            instructor.ContactoNombrePersona = "Laura Arocha";
            instructor.ContactoTelefonoPersona = "9757979";
            instructor.FechaNacimientoPersona = new DateTime(1990, 12, 11);
            instructor.GeneroPersona = "F";
            Entidades.Instructor.Instructor instructorResp = objInstructor.ConsultarInstructor("19290620");
            Assert.AreEqual(instructor.NombrePersona1, instructorResp.NombrePersona1.TrimEnd());
        }

        [Test]
        public void TestEliminarInstructor()
        {
            LogicaInstructor objInstructor = new LogicaInstructor();

            Entidades.Instructor.Instructor instructor = new Entidades.Instructor.Instructor();
            string cedula = "19290620";
            
            Assert.AreEqual(true, objInstructor.EliminarInstructor(cedula));
        }

        [Test]
        public void TestModificarInstructor()
        {
            LogicaInstructor objInstructor = new LogicaInstructor();

            Entidades.Instructor.Instructor instructor = new Entidades.Instructor.Instructor();
            string cedula = "19290620";

           // Assert.AreEqual(true, objInstructor.ModificarInstructor(cedula));
        }

    }
}