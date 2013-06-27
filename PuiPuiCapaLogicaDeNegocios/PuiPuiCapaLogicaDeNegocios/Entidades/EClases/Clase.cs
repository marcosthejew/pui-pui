using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EClases
{
    public class Clase : AEntidad
    {
        #region Atributos

        private String _nombre;
        private int _idClase;
        private String _descripcion;
        private int _status;
        #endregion

        #region Getter Setter

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int IdClase
        {
            get { return _idClase; }
            set { _idClase = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        #endregion

        #region Constructores

        public Clase()
        {
        }
        public Clase(int id)
        {
            this._idClase = id;
        }
        public Clase(String nombre, int idClase, String descripcion)
        {
            this._descripcion = descripcion;
            this._nombre = nombre;
            this._idClase = idClase;
        }
        public Clase(String nombre, int idClase, String descripcion, int st)
        {
            this._status = st;
            this._descripcion = descripcion;
            this._nombre = nombre;
            this._idClase = idClase;
        }


        #endregion


        public string serializar()
        {
            string resultado = "<Clase>";

            resultado += "<Id>" + Id + "</Id>";
            resultado += "<Status>" + Status + "</Status>";
            resultado += "<Descripcion>" + Descripcion + "</Descripcion>";
            resultado += "<IdClase>" + IdClase + "</IdClase>";
            resultado += "<Nombre>" + Nombre + "</Nombre>";
            resultado += "</Clase>";
            return resultado;

        }
    }
    }
