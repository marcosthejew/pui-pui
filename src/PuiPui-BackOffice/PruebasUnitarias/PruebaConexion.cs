using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using System.Data.SqlClient;
using System.Configuration;

namespace PuiPui_BackOffice.PruebasUnitarias
{
    public class PruebaConexion
    {
        [Test]
        public void PruebaAbrirConexionPrueba()
        {
            IConexionSqlServer bd = new ConexionSqlServer();
            SqlConnection conexion = new SqlConnection();
            String esperado = "Open";

            bd.AbrirConexion();
            Assert.AreEqual(esperado, bd.ObjetoConexion().State.ToString());

        }


    }
}