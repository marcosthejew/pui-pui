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
        private String _descripcion;
        private int _status;
        #endregion

        #region Getter Setter

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
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
            this._id = id;
        }
        public Clase(String nombre, int id, String descripcion)
        {
            this._descripcion = descripcion;
            this._nombre = nombre;
            this._id = id;
        }
        public Clase(String nombre, int idClase, String descripcion, int st)
        {
            this._status = st;
            this._descripcion = descripcion;
            this._nombre = nombre;
            this._id = idClase;
        }
        public Clase(String nombre,  String descripcion, int st)
        {
            this._status = st;
            this._descripcion = descripcion;
            this._nombre = nombre;
            
        }

        #endregion


        public string serializar()
        {
            string resultado = "<Clase>";

            resultado += "<Id>" + Id + "</Id>";
            resultado += "<Status>" + Status + "</Status>";
            resultado += "<Descripcion>" + Descripcion + "</Descripcion>";
            resultado += "<Nombre>" + Nombre + "</Nombre>";
            resultado += "</Clase>";
            return resultado;

        }
    }
    }
