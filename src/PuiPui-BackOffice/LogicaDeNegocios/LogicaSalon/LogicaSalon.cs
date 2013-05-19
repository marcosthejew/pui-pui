using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;

namespace PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon
{
    public class LogicaSalon
    {

        #region Atributos

        private Salon _salon;
        private SQLServerSalon _accesoSalon;

        #endregion

        #region Constructor

        public LogicaSalon()
        {
            _salon = new Salon();
            _accesoSalon= new SQLServerSalon();

        }


        #endregion

        #region Metodos

        private List<Salon> ConsultarSalones(){

            List<Salon> listaSalon ;
            //conectar a la bd
            listaSalon = _accesoSalon.ConsultarSalones();

            return listaSalon;
        
        }

        private Boolean ModificarSalones(Salon salon)
        {

            Boolean retorno = false;

            retorno = _accesoSalon.ModificarSalon(salon);
            
            return retorno;

        }

        private Boolean AgregarSalones(String ubicacion,int capacidad)
        {
            Boolean resultado = false;
            _salon.Ubicacion = ubicacion;
            _salon.Capacidad = capacidad;
            _salon.Status = 0;
            resultado = _accesoSalon.AgregarSalon(_salon);
            //conectar a la bd

            return resultado;

        }

        #endregion

    }
}