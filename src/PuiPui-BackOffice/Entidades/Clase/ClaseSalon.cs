using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.Entidades.Instructor;

namespace PuiPui_BackOffice.Entidades.Clase
{
    public class ClaseSalon
    {

        #region Atributos

        private int _id;
        private Clase _clase;
        private Salon.Salon _salon;
        private Instructor.Instructor _instructor;
        private int _disponibilidad;
 
        #endregion

        #region Getter Setter
      
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Clase Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
        public Salon.Salon Salon
        {
            get { return _salon; }
            set { _salon = value; }
        }
        public Instructor.Instructor Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }
        public int Disponibilidad
        {
            get { return _disponibilidad; }
            set { _disponibilidad = value; }
        }

        #endregion 

        #region Constructor

        public ClaseSalon() { 
        }
        public ClaseSalon(Salon.Salon sal, Clase clas, Instructor.Instructor ins)
        {
            this.Instructor = ins;
            this.Salon = sal;
            this.Clase = clas;
        }
        public ClaseSalon(int iid,Salon.Salon sal, Clase clas, Instructor.Instructor ins, int disp)
        {
            this._id = iid;
            this._instructor = ins;
            this._salon = sal;
            this._clase = clas;
            this._disponibilidad = disp;
        }
        #endregion

    }
}