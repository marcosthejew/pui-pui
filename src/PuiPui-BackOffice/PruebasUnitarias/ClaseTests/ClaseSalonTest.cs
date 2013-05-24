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
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;

namespace PuiPui_BackOffice.PruebasUnitarias.ClaseTests
{
    [TestFixture]
   
    public class ClaseSalonTest
    {
         List<ClaseSalon> _listaClaseAux, _listaClase;
        SQLServerClaseSalon _accesoClaseSalon;
        ClaseSalon _claseSalon;

        [SetUp]
        public void SetUp()
        {
            Entidades.Instructor.Instructor ins = new Entidades.Instructor.Instructor();
            ins.IdPersona = 1;
            _claseSalon = new ClaseSalon(1, new Salon(2), new Clase(1), ins, 0);
            _accesoClaseSalon = new SQLServerClaseSalon();
            _listaClaseAux = new List<ClaseSalon>();

            _listaClaseAux.Add(_claseSalon);
            ins.IdPersona = 2;
            _claseSalon = new ClaseSalon(2, new Salon(2), new Clase(2), ins, 1);
            _listaClaseAux.Add(_claseSalon);
            ins.IdPersona = 3;
            _claseSalon = new ClaseSalon(3, new Salon(3), new Clase(4), ins, 1);
            _listaClaseAux.Add(_claseSalon);
            

        }
        [Test]
        public void AgregarClaseTest()
        {
            try
            {
                Entidades.Instructor.Instructor ins= new Entidades.Instructor.Instructor();
                ins.IdPersona=1;
                _claseSalon = new ClaseSalon(new Salon(2),new Clase(1), ins);
                _accesoClaseSalon = new SQLServerClaseSalon();
                Assert.IsTrue(_accesoClaseSalon.AgregarClaseSalon(_claseSalon));
            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {

            }

        }

        [Test]
        public void ModificarTest()
        {
            try
            {
                Entidades.Instructor.Instructor ins = new Entidades.Instructor.Instructor();
                ins.IdPersona = 1;
                _claseSalon = new ClaseSalon(1,new Salon(2), new Clase(1), ins,0);
                _accesoClaseSalon = new SQLServerClaseSalon();
                Assert.IsTrue(_accesoClaseSalon.ModificarSalonClase(_claseSalon));
            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {

            }
        }

        [Test]
        public void DetalleTest()
        {
            try
            {

                
               
                _listaClase = _accesoClaseSalon.ListarSalonesClase();

                Assert.NotNull(_listaClase);

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {
            }
        }

      
        [Test]
        public void BuscarClaseTest()
        {
            try
            {




                _listaClase = _accesoClaseSalon.ListarSalonesClaseTclase("Tae Box");

                foreach (ClaseSalon clas in _listaClase)
                {

                    Assert.Equals(clas.Clase.Nombre, "Tae Box");


                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {
            }
        }


        [Test]
        public void BuscarSalonTest()
        {
            try
            {




                _listaClase = _accesoClaseSalon.ListarSalonesClaseTsalon("Primer Piso");

                foreach (ClaseSalon clas in _listaClase)
                {

                    Assert.Equals(clas.Salon.Ubicacion, "Primer Piso");


                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {
            }
        }

        [Test]
        public void BuscarInstructorTest()
        {
            try
            {




                _listaClase = _accesoClaseSalon.ListarSalonesClaseTinstructor("Juan");

                foreach (ClaseSalon clas in _listaClase)
                {

                    Assert.Equals(clas.Instructor.NombrePersona1,"Juan");


                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {
            }
        }

        [Test]
        public void BuscarStatusTrueTest()
        {
            try
            {

                _listaClase = _accesoClaseSalon.ListarSalonesClaseTdisponible(1);


                foreach (ClaseSalon clas in _listaClase)
                {

                    Assert.IsTrue(clas.Disponibilidad == 1);

                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {
            }
        }

        [Test]
        public void BuscarStatusFalseTest()
        {
            try
            {

                _listaClase = _accesoClaseSalon.ListarSalonesClaseTdisponible(0);


                foreach (ClaseSalon clas in _listaClase)
                {

                    Assert.IsTrue(clas.Disponibilidad == 0);

                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion)
            {
            }
        }


    }
}