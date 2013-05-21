using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.Entidades.Ejercicio
{
    public class Ejercicio
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private Musculo _musculo;

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

        public Ejercicio()
        {    
        }

        public Ejercicio(int id, string nombre, string descripcion, Musculo musculo)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _musculo = musculo;
        }
    }
}