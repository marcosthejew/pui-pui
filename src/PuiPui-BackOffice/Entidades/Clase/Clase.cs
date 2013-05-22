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
        private int _status;

        #endregion

        #region Getter Setter

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        
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
        public Clase(String Nombre, int IdClase, String Descripcion,int stat)
        {
            this.Status = stat;
            this._descripcion = Descripcion;
            this._nombre = Nombre;
            this._idClase = IdClase;
        }
        public Clase()
        {
        }
        public Clase(int id)
        {
            this.IdClase = id;
        }

        #endregion

        #region Metodos

        #endregion
    }
}