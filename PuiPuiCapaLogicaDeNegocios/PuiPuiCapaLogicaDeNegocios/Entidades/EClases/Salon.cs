﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EClases
{
    /// <summary>
    /// Representa un salon del gimnasio.
    /// </summary>
    public class Salon : AEntidad
    {

        #region Atributos

        private int _idSalon;
        private String _ubicacion;
        private int _capacidad;
        private int _status;

        #endregion

        #region Metodos GetterSetter
        public int IdSalon
        {
            get { return _idSalon; }
            set { _idSalon = value; }
        }
        public String Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
        }

        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region Contructores

        public Salon(int idSalon, String ubicacion, int capacidad)
        {
            this._capacidad = capacidad;
            this._idSalon = idSalon;
            this._ubicacion = ubicacion;

        }
        public Salon(int idSalon, String ubicacion, int capacidad, int st)
        {
            this._status = st;
            this._capacidad = capacidad;
            this._idSalon = idSalon;
            this._ubicacion = ubicacion;

        }
        public Salon()
        {

        }
        public Salon(int id)
        {
            this.IdSalon = id;
        }
        #endregion

        #region Metodos


        #endregion
    }
}