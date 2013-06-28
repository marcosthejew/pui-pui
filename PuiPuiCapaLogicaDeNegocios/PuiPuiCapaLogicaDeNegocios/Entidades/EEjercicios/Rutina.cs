using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios
{
    public class Rutina : AEntidad
    {
        
        #region Atributos

        private string nombre;
        private string descripcion;
        private List<Ejercicio> listaEjercicios;
        private byte inactivo;

        #endregion

        #region Getters y Setters

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public List<Ejercicio> ListaEjercicios
        {
            get { return listaEjercicios; }
            set { listaEjercicios = value; }
        }

        public byte Inactivo
        {
            get { return inactivo; }
            set { inactivo = value; }
        }
        #endregion

        #region Constructor

        public Rutina() { }

        #endregion

        #region Metodos

        public string SerializarRutinas(Rutina rutina)
        {
            string cadena = "";
            cadena += "<Rutina>";

            cadena += "<Id>" + rutina.Id + "</Id>";
            cadena += "<Nombre>" + rutina.Nombre + "</Nombre>";
            cadena += "<Descripcion>" + rutina.Descripcion + "</Descripcion>";
            cadena += "</Rutina>";


            return cadena;

        
        }

        public string SerializarEjercicio(Ejercicio ejercicio)
        {
            string cadena = "";
            cadena += "<Ejercicio>";
            cadena += "<Id>" + ejercicio.Id + "</Id>";
            cadena += "<Nombre>" + ejercicio.Nombre + "</Nombre>";
            cadena += "<Descripcion>" + ejercicio.Descripcion + "</Descripcion>";
            cadena += "<Duracion>" + ejercicio.Duracion + "</Duracion>";
            cadena += "<Repeticiones>" + ejercicio.Repeticiones + "</Repeticiones>";
            cadena += "</Ejercicio>";

            return cadena;
        }
        #endregion
    }
}