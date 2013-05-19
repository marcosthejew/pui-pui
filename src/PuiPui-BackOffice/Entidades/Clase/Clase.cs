using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.Entidades.Clase
{
    public class Clase
    {

        #region Atributos

        private String _nombre;
        private int _idClase;
        private String _descripcion;
        
        #endregion

        #region Getter Setter

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public int IdClase
        {
            get { return _idClase; }
            set { _idClase = value; }
        }
       
     
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        #endregion

        #region Constructores

        public Clase(String Nombre, int IdClase, String Descripcion)
        {
            this._descripcion = Descripcion;
            this._nombre = Nombre;
            this._idClase = IdClase;
        }
        public Clase()
        {
        }

        #endregion

        #region Metodos

        #endregion
    }
}