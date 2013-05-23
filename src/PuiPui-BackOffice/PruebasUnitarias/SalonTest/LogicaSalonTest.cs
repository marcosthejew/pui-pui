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
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;
namespace PuiPui_BackOffice.PruebasUnitarias.SalonTest
{
    [TestFixture]
    public class LogicaSalonTest
    {
        private ClaseSalon _claseSalon;
        private Clase _clase;
        private Salon _salon;
        private Entidades.Instructor.Instructor _instructor;
        private DataTable _tabla, _tablaAux;
        private List<Clase> _listaClaseAux;
        private List<Salon> _listaSalonAux;
        private List<ClaseSalon> _listaClaseSalonAux;
        private LogicaSalon _acceso;

        [SetUp]
        public void SetUp()
        {
            _clase = new Clase("MudFight", 0, "pelea en barro");
            _salon = new Salon(3, "Primer Piso", 100, 1);
            _acceso = new LogicaSalon();
            _listaClaseAux = new List<Clase>();
            _clase = new Clase("Tae Box", 3, "clase de ejercicios fuertes", 1);
            _listaClaseAux.Add(_clase);
            _clase = new Clase("Spinning", 1, "clase de ejercicios fuertes", 1);
            _listaClaseAux.Add(_clase);
            _clase = new Clase("DragonFight", 2, "clase de ejercicios fuertes", 1);
            _listaClaseAux.Add(_clase);
            _instructor = new Entidades.Instructor.Instructor();
            _instructor.IdPersona = 1;
            _tabla = new DataTable();
            _tabla.Columns.Add("No.", typeof(string));
            _tabla.Columns.Add("Nombre", typeof(string));
            _tabla.Columns.Add("Estatus", typeof(string));
            _claseSalon = new ClaseSalon(1, _salon, _clase, _instructor, 1);
            foreach (Clase item in _listaClaseAux)
            {
                _tabla.Rows.Add(item.IdClase, item.Nombre, item.Status);
            }


        }


        [Test]
        public void ConsultarSalonTest()
        {
            _tablaAux = _acceso.ConsultarSalones();

            Assert.NotNull(_tablaAux);

        }

        [Test]
        public void ConsultarClaseSalonTest()
        {
            _tablaAux = _acceso.ConsultarSalonesClase();

            Assert.NotNull(_tablaAux);

        }

        [Test]
        public void ObtenerSalonTest()
        {
            _listaSalonAux = _acceso.ObtenerSalones();
            Assert.NotNull(_listaSalonAux);
            Assert.True(_listaSalonAux[0].IdSalon == 1);
            Assert.True(_listaSalonAux[1].IdSalon == 2);
            Assert.True(_listaSalonAux[2].IdSalon == 3);
        }


        [Test]
        public void ObtenerClaseSalonTest()
        {
            _listaClaseSalonAux = _acceso.SalonesClase();
            Assert.NotNull(_listaSalonAux);
            Assert.True(_listaClaseSalonAux[0].Id == 1);
            Assert.True(_listaClaseSalonAux[1].Id == 2);
            Assert.True(_listaClaseSalonAux[2].Id == 3);
        }

        [Test]
        public void ModificarSalonTest()
        {
            Assert.True(_acceso.ModificarSalones(_salon));
        }

        [Test]
        public void ModificarSalonClaseTest()
        {
            Assert.True(_acceso.ModificarSalonesClase(_claseSalon));
        }


        [Test]
        public void AgregarSalonClasesTest()
        {
            Assert.True(_acceso.AgregarSalonesClase(1,1,1));
        }


        [Test]
        public void AgregarClasesTest()
        {
            Assert.True(_acceso.AgregarSalones(_salon.Ubicacion,_salon.Capacidad));
        }


        [Test]
        public void ConsultarSalonUbicacionTest()
        {
            _tablaAux = _acceso.ConsultarSalonesUbicacion("Primer Piso");
            Assert.NotNull(_tablaAux);
        }

        [Test]
        public void ConsultarSalonCapacidadMayorTest()
        {
            _tablaAux = _acceso.ConsultarSalonesCapacidadMayo(90);
            Assert.NotNull(_tablaAux);
        }


        [Test]
        public void ConsultarSalonCapacidadMenorTest()
        {
            _tablaAux = _acceso.ConsultarSalonesCapacidadMenor(90);
            Assert.NotNull(_tablaAux);
        }
        
        [Test]
        public void ConsultarSalonEstatusTest()
        {
            _tablaAux = _acceso.ConsultarSalonesStatus(1);
            Assert.NotNull(_tablaAux);


            _tablaAux = _acceso.ConsultarSalonesStatus(0);
            Assert.NotNull(_tablaAux);
        }

        [Test]
        public void ConsultarClaseSalonEstatusTest()
        {
            _tablaAux = _acceso.ConsultarSalonesClasePorEstatus(1);
            Assert.NotNull(_tablaAux);


            _tablaAux = _acceso.ConsultarSalonesClasePorEstatus(0);
            Assert.NotNull(_tablaAux);
        }

        [Test]
        public void ConsultarClaseSalonClaseTest()
        {
            _tablaAux = _acceso.ConsultarSalonesClasePorClase("Tae Box");
            Assert.NotNull(_tablaAux);

        }

          [Test]
        public void ConsultarClaseSalonUbicacionTest()
        {
            _tablaAux = _acceso.ConsultarSalonesClasePorUbicacion("Primer Piso");
            Assert.NotNull(_tablaAux);

        }


          [Test]
          public void ConsultarClaseSalonInstructorTest()
          {
              _tablaAux = _acceso.ConsultarSalonesClasePorInstructor("Juan");
              Assert.NotNull(_tablaAux);

          }
    }
}