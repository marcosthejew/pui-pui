using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.ReservaClase
{
    public class ClaseSalon
    {

        #region Atributos

        private int _idClaseSalon;
        private bool _isReservado;
        private int _idClase;
        private int _idSalon;

        #endregion

        #region Getters Setters

        public int IdClaseSalon
        {
            get { return _idClaseSalon; }
            set { _idClaseSalon = value; }
        }
       

        public bool IsReservado
        {
            get { return _isReservado; }
            set { _isReservado = value; }
        }
        

        public int IdClase
        {
            get { return _idClase; }
            set { _idClase = value; }
        }
        

        public int IdSalon
        {
            get { return _idSalon; }
            set { _idSalon = value; }
        }

        #endregion

        #region Contructores

        public ClaseSalon()
        {
        }
        #endregion
    }
}