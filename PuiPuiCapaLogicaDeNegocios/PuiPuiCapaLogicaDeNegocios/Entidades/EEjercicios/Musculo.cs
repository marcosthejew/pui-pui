using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios
{
    public class Musculo : AEntidad
    {

        #region Atributos

        private string _nombreMusculo;
        private string _descripcion;
        private bool _status;        

        #endregion

        #region MetodosGetSet

        public string NombreMusculo
        {
            get { return _nombreMusculo; }
            set { _nombreMusculo = value; }
        }

        public int IdMusculo
        {
            get { return _id; }
            set { _id = value; }

        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion MetodoGetSet

        #region Constructores

        public Musculo()
        {

        }

        public Musculo(int id)
        {
            _id = id;
        }

        public Musculo(string nombre)
        {
            _nombreMusculo = nombre;
        }

        public Musculo(int id, string nombre)
        {
            _id = id;
            _nombreMusculo = nombre;
        }

        public Musculo(int id, string nombre, string descripcion) {
            _id = id;
            _nombreMusculo = nombre;
            _descripcion = descripcion;
        }

        public Musculo(int id, string nombre, string descripcion, bool status)
        {
            _id = id;
            _nombreMusculo = nombre;
            _descripcion = descripcion;
            _status = status;
        }

        #endregion Constructores

    }
}