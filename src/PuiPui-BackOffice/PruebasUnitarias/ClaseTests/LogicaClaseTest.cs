using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using NUnit.Framework;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;
namespace PuiPui_BackOffice.PruebasUnitarias.ClaseTests
{
   [TestFixture]
    public class LogicaClaseTest
    {
       private Clase _clase;
       private DataTable _tabla, _tablaAux;
       private List<Clase> _listaClaseAux;
       private LogicaClase _accesoLogica;

       [SetUp]
       public void SetUp()
       {
           _clase = new Clase("MudFight", 0, "pelea en barro");
           _accesoLogica = new LogicaClase();
           _listaClaseAux = new List<Clase>();
           _clase = new Clase("Tae Box", 3, "clase de ejercicios fuertes", 1);
           _listaClaseAux.Add(_clase);
           _clase = new Clase("Spinning", 1, "clase de ejercicios fuertes", 1);
           _listaClaseAux.Add(_clase);
           _clase = new Clase("DragonFight", 2, "clase de ejercicios fuertes", 1);
           _listaClaseAux.Add(_clase);

           _tabla = new DataTable();
           _tabla.Columns.Add("No.", typeof(string));
           _tabla.Columns.Add("Nombre", typeof(string));
           _tabla.Columns.Add("Estatus", typeof(string));

           foreach (Clase item in _listaClaseAux)
           {
               _tabla.Rows.Add(item.IdClase, item.Nombre, item.Status);
           }


       }

       [Test]
       public void ConsultarClaseTest()
       {
           _tablaAux = _accesoLogica.ConsultarClase();

           Assert.NotNull(_tablaAux);
           
       }

       [Test]
       public void ObtenerDetalleTest()
       {
           _clase = _accesoLogica.ObtenerDetalleClases(1);
           Assert.True(_clase.IdClase == 1);
           Assert.AreEqual(_clase.Nombre, "Spinning");
       }

       [Test]
       public void ObtenerClasesTest()
       {
           _listaClaseAux = _accesoLogica.ObtenerClases();
           Assert.NotNull(_listaClaseAux);
           Assert.True(_listaClaseAux[0].IdClase == 1);
           Assert.True(_listaClaseAux[1].IdClase == 2);
           Assert.True(_listaClaseAux[2].IdClase == 3);
       }

       [Test]
       public void ModificarClasesTest()
       {
           Assert.True(_accesoLogica.ModificarClase(_clase));
       }
       [Test]
       public void AgregarClasesTest()
       {
           Assert.True(_accesoLogica.AgregarClase(_clase.Nombre,_clase.Descripcion));
       }

       [Test]
       public void ConsultarClasesNombreTest()
       {
           _tablaAux = _accesoLogica.ConsultarClasesNombre("Tae Box");
           Assert.NotNull(_tablaAux);
       }

       [Test]
       public void ConsultarClasesEstatusTest()
       {
           _tablaAux = _accesoLogica.ConsultarClaseStatus(1);
           Assert.NotNull(_tablaAux);
       }

    }
}