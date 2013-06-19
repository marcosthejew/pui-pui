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

        #endregion Constructores

    }
}