using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios
{
    public class Ejercicio : AComponenteRutina
    {
        #region Atributos

        private string _nombre;
        private string _descripcion;
        private Musculo _musculo;

        #endregion 

        #region MetodosGetSet

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Musculo Musculo
        {
            get { return _musculo; }
            set { _musculo = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        #endregion MetodosGetSet

        #region Constructores

        public Ejercicio()
        {
        }

        public Ejercicio(int id)
        {
            _id = id;
            
        }

        public Ejercicio(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
           
        }

        public Ejercicio(int id, string nombre, string descripcion)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
           
        }

        public Ejercicio(int id, string nombre, string descripcion, Musculo musculo)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _musculo = musculo;
        }

        #endregion Constructores

    }
}