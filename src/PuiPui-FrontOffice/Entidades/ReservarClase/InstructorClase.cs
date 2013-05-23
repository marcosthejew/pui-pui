using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.ReservarClase
{
    public class InstructorClase
    {

        #region atributos

        private int _idinstructor;
        private String _nombre;
       
              
        #endregion

        #region Getters Setters

        public int Idinstructor
        {
            get { return _idinstructor; }
            set { _idinstructor = value; }
        }
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
      
        #endregion

        #region Constructores

        public InstructorClase()
        { 
        }

        #endregion
    }
}