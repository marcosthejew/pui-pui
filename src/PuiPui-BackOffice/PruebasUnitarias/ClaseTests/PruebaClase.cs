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

namespace PuiPui_BackOffice.PruebasUnitarias.ClaseTests
{
    [TestFixture]
    public class SQLClaseTest
    {
        Clase _clase;
        SQLServerClase _accesoClase;
        List<Clase> _listaClaseAux, _listaClase;
        [Test]
        public void AgregarClaseTest()
            {
                try
                {
                    
                    _clase = new Clase("MudFight", 0, "pelea en barro");
                    _accesoClase = new SQLServerClase();
                    Assert.IsTrue(_accesoClase.AgregarClase(_clase));
                }
                catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion e)
                {
                    
                }
              
            }

       [Test]
        public void ModificarTest()
        {
            try
            {
                _accesoClase = new SQLServerClase();
                _clase = new Clase("TaeBox",3,"clase de ejercicios fuertes",1);
                Assert.IsTrue(_accesoClase.ModificarClase(_clase));
            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion e)
            {
                
            }
        }

      [Test]
        public void DetalleTest()
        {
            try
            {

                _listaClaseAux = new List<Clase>();
                _accesoClase = new SQLServerClase();
                _clase = new Clase("Tae Box", 3, "clase de ejercicios fuertes", 1);


                _listaClase = _accesoClase.BusquedaNombreClase("Tae Box");

                foreach (Clase clas in _listaClase)
                {

                    Assert.Equals(clas.Descripcion, _clase.Descripcion);


                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

       [Test]
        public void ConsultarTest()
        {
            try
            {

            _listaClaseAux = new List<Clase>();
            _accesoClase = new SQLServerClase();
            _clase = new Clase("Tae Box", 3, "clase de ejercicios fuertes", 1);
            _listaClaseAux.Add(_clase);
            _clase = new Clase("Spinning", 1, "clase de ejercicios fuertes", 1);
            _listaClaseAux.Add(_clase);
            _clase = new Clase("DragonFight", 2, "clase de ejercicios fuertes", 1);
            _listaClaseAux.Add(_clase);

            _listaClase = _accesoClase.ConsultarClases();
            int i=0;
            foreach (Clase clas in _listaClase)
            {
                Assert.IsTrue(clas.IdClase == _listaClaseAux[i].IdClase);
                Assert.Equals(clas.Nombre, _listaClaseAux[i].Nombre);
                i++;
                
            }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

       [Test]
        public void BuscarNombreTest()
        {
            try
            {

                _listaClaseAux = new List<Clase>();
                _accesoClase = new SQLServerClase();
                _clase = new Clase("Tae Box", 3, "clase de ejercicios fuertes", 1);
             

                _listaClase = _accesoClase.BusquedaNombreClase("Tae Box");
                
                foreach (Clase clas in _listaClase)
                {
                    
                    Assert.Equals(clas.Nombre, _clase.Nombre);
                    

                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

       [Test]
        public void BuscarStatusTrueTest()
        {
            try
            {
                _accesoClase = new SQLServerClase();
                _listaClase = _accesoClase.BusquedaStatusClase(1);


                foreach (Clase clas in _listaClase)
                {

                    Assert.IsTrue(clas.Status==1);

                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

       [Test]
        public void BuscarStatusFalseTest()
        {
            try
            {
                _accesoClase = new SQLServerClase();
                _listaClase = _accesoClase.BusquedaStatusClase(0);


                foreach (Clase clas in _listaClase)
                {

                    Assert.IsTrue(clas.Status == 0);

                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }


    }
}