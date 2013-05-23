using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using NUnit.Framework;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades.Ejercicio;
using PuiPui_BackOffice.LogicaDeNegocios.Ejercicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PuiPui_BackOffice.PruebasUnitarias.Ejercicio
{
    [TestClass]
    public class SQLEjercicioTest
    {
        [TestMethod]
        public void TestAgregarEjercicio()
        {
            LogicaEjercicio objEjercicio = new LogicaEjercicio();
            string nombre = "nombre";
            string descripcion = "descripcion";
            string musculo = "bicep";
            Assert.AreEqual(true, objEjercicio.AgregarEjercicio(nombre, descripcion, musculo));
        }

        [TestMethod]
        public void TestActualizarEjercicio()
        {
            LogicaEjercicio objEjercicio = new LogicaEjercicio();
            string nombreInicial = "nombre";
            Entidades.Ejercicio.Ejercicio ejercicio = new Entidades.Ejercicio.Ejercicio();
            ejercicio.Nombre = "nombre nuevo";
            ejercicio.Descripcion = "descripcion nueva";
            string nombreMusculo = "tricep";
            Assert.AreEqual(true, objEjercicio.ActualizarEjercicio(nombreInicial, ejercicio, nombreMusculo));
        }

        [TestMethod]
        public void TestConsultarEjercicio()
        {
            LogicaEjercicio objEjercicio = new LogicaEjercicio();
            Entidades.Ejercicio.Ejercicio ejercicio = new Entidades.Ejercicio.Ejercicio();
            ejercicio.Nombre = "nombre nuevo";
            ejercicio.Descripcion = "descripcion nueva";

            Assert.AreEqual(ejercicio.Descripcion, objEjercicio.ConsultarEjercicio(ejercicio.Nombre).Descripcion.TrimEnd());
        }

        [TestMethod]
        public void TestEliminarEjercicio()
        {
            LogicaEjercicio objEjercicio = new LogicaEjercicio();
            Entidades.Ejercicio.Ejercicio ejercicio = new Entidades.Ejercicio.Ejercicio();
            ejercicio.Nombre = "nombre nuevo";
            ejercicio.Descripcion = "descripcion nueva";

            Assert.AreEqual(true, objEjercicio.EliminarEjercicio(ejercicio.Nombre));
        }
    }
}