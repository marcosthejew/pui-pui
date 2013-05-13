using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.Entidades.Instructor
{
    public class Instructor : Cliente.Persona{
    
        private IList<Horario> _horario;
        public Instructor()
        {

            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}