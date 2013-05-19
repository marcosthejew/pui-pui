using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.Entidades.Salon
{
    public class Salon
    {
        #region Atributos

        private String _nombre;
        private int _idSalon;
        private String _ubicacion;
        private int _capacidad;
        private int status;

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
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region Contructores

        public Salon(String nombre, int idSalon, String ubicacion, int capacidad)
        {
            this._capacidad = capacidad;
            this._idSalon = idSalon;
            this._nombre = nombre;
            this._ubicacion = ubicacion;

        }
        public Salon()
        {

        }

        #endregion

        #region Metodos


        #endregion
    }
}