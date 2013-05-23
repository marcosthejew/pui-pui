using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.Entidades.Instructor
{
    public class Instructor : Cliente.Persona
    {

        private List<Horario> _horario;

        public Instructor(int cedula, string nombre1, string nombre2, string apellido1, string apellido2,
         string genero, DateTime fechaNacimiento, string ciudad, string direccion, string correo, string contacto,
         string telfContacto, List<Horario> horario)
            : base(cedula, nombre1, nombre2, apellido1, apellido2, genero, fechaNacimiento, ciudad, direccion, correo,
             contacto, telfContacto)
        {
            _horario = horario;
        }


        public Instructor()
        {
            _horario = new List<Horario>();   
        }

        public List<Horario> Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

    }
}