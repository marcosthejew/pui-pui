﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
namespace PuiPui_BackOffice.PruebasUnitarias.ClaseTests
{
    [TestClass]
    public class SQLClaseTest
    {
        Clase _clase;
        SQLServerClase _accesoClase;
        List<Clase> _listaClaseAux, _listaClase;
        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
        public void DetalleTest()
        {
             _accesoClase = new SQLServerClase();
             _clase = new Clase("TaeBox",3,"clase de ejercicios fuertes",1);
             
        }

        [TestMethod]
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

        [TestMethod]
        public void BuscarNombreTest()
        {
            
        }
    }
}