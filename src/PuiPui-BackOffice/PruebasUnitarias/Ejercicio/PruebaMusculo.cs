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
    public class SQLMusculoTest
    {
        [TestMethod]
        public void TestAgregarMusculo()
        {
            LogicaMusculo objMusculo = new LogicaMusculo();
            string nombreMusculo = "pantorrilla";
            Assert.AreEqual(true, objMusculo.AgregarMusculo(nombreMusculo));
        }

        [TestMethod]
        public void TestEliminarMusculo()
        {
            LogicaMusculo objMusculo = new LogicaMusculo();
            string nombreMusculo = "pantorrilla";
            Assert.AreEqual(true, objMusculo.EliminarMusculo(nombreMusculo));
        }

    }
}