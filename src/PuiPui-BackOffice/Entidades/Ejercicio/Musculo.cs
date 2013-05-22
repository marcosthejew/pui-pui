using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.Entidades.Ejercicio
{
    public class Musculo
    {
        private int _idMusculo;
        private string _nombreMusculo;

        public string NombreMusculo
        {
            get { return _nombreMusculo; }
            set { _nombreMusculo = value; }
        }

        public int IdMusculo
        {
            get { return _idMusculo; }
            set { _idMusculo = value; }

        }
        
        public Musculo(int id, string nombre)
        {
            _idMusculo = id;
            _nombreMusculo = nombre;
        }

        public Musculo(string nombre)
        {
            _nombreMusculo = nombre;
        }

        public Musculo()
        {

        }
    }
}