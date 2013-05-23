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
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;


namespace PuiPui_BackOffice.PruebasUnitarias.SalonTest
{
    [TestClass]
    public class PruebaSalon
    {

        Salon _salon;
        SQLServerSalon _accesoSalon;
        List<Salon> _listaSalonAux, _listaSalon;

        [TestMethod]
        public void AgregarSalonTest()
        {
            try
            {

                _salon = new Salon(0, "a la derecha", 43, 1);
                _accesoSalon = new SQLServerSalon();
                Assert.IsTrue(_accesoSalon.AgregarSalon(_salon));
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
                _accesoSalon = new SQLServerSalon();
                _salon = new Salon(0, "a la derecha", 43, 1);
                Assert.IsTrue(_accesoSalon.ModificarSalon(_salon));
            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion e)
            {

            }
        }

        [TestMethod]
        public void BusuedaUbicacionTest()
        {
            try
            {

                _listaSalonAux = new List<Salon>();
                _accesoSalon = new SQLServerSalon();
                _salon = new Salon(3, "Primer Piso", 100, 1);


                _listaSalon = _accesoSalon.BusquedaUbicacion("Primer Piso");

                foreach (Salon sal in _listaSalon)
                {

                    Assert.Equals(sal.Ubicacion, _salon.Ubicacion);


                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

        [TestMethod]
        public void ConsultarTest()
        {
            try
            {

                _listaSalonAux = new List<Salon>();
                _accesoSalon = new SQLServerSalon();
                _salon = new Salon(3, "Primer Piso", 100, 1);
                _listaSalonAux.Add(_salon);
                _salon = new Salon(3, "Primer Piso", 100, 1);
                _listaSalonAux.Add(_salon);
                _salon = new Salon(3, "Primer Piso", 100, 1);
                _listaSalonAux.Add(_salon);

                _listaSalon = _accesoSalon.ConsultarSalones();
                int i = 0;
                foreach (Salon clas in _listaSalon)
                {
                    Assert.IsTrue(clas.IdSalon == _listaSalonAux[i].IdSalon);
                    Assert.Equals(clas.Ubicacion, _listaSalonAux[i].Ubicacion);
                    Assert.IsTrue(clas.Capacidad == _listaSalonAux[i].Capacidad);
                    i++;
                    if (i==3)
                    {
                        break;
                    }

                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

        [TestMethod]
        public void BuscarCapacidadMenorTest()
        {
            try
            {

                _listaSalonAux = new List<Salon>();
                _accesoSalon = new SQLServerSalon();
                _salon = new Salon(3, "Primer Piso-Ala Oeste", 40, 1);


                _listaSalon = _accesoSalon.BusquedaCapacidadMenorSalon(90);

                foreach (Salon clas in _listaSalon)
                {

                    Assert.IsTrue(clas.Capacidad<=90);


                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

        [TestMethod]
        public void BuscarCapacidadMayorTest()
        {
            try
            {

                _listaSalonAux = new List<Salon>();
                _accesoSalon = new SQLServerSalon();
                _salon = new Salon(3, "Primer Piso-Ala Oeste", 40, 1);


                _listaSalon = _accesoSalon.BusquedaCapacidadMayorSalon(90);

                foreach (Salon clas in _listaSalon)
                {

                    Assert.IsTrue(clas.Capacidad >= 90);


                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

        [TestMethod]
        public void BuscarStatusTrueTest()
        {
            try
            {
                _accesoSalon = new SQLServerSalon();
                _salon = new Salon(3, "Primer Piso-Ala Oeste", 40, 1);
                _listaSalon = _accesoSalon.BusquedaStatusSalon(1);

                foreach (Salon clas in _listaSalon)
                {

                    Assert.IsTrue(clas.Status == 1);

                }

            }
            catch (AccesoDeDatos.Excepciones_BD.ExcepcionConexion E)
            {
            }
        }

        [TestMethod]
        public void BuscarStatusFalseTest()
        {
            try
            {
                _accesoSalon = new SQLServerSalon();
                _salon = new Salon(3, "Primer Piso-Ala Oeste", 40, 1);
                _listaSalon = _accesoSalon.BusquedaStatusSalon(0);

                foreach (Salon clas in _listaSalon)
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