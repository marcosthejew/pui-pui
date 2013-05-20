using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
namespace PuiPui_BackOffice.LogicaDeNegocios.LogicaClase
{
    public class LogicaClase
    {

        #region Atributos

        private Clase _clase;
        private SQLServerClase _accesoClase;

        #endregion

        #region Constructor

        public LogicaClase()
        {
            _clase = new Clase();
            _accesoClase = new SQLServerClase();

        }

        #endregion

        #region Metodos

        private List<Clase> ConsultarClase()
        {

            List<Clase> listaClase;
            //conectar a la bd
            listaClase = _accesoClase.ConsultarClases();

            return listaClase;

        }

        private Boolean ModificarClase(Clase clase)
        {

            Boolean retorno = false;

            retorno = _accesoClase.ModificarClase(clase);

            return retorno;

        }

        private Boolean AgregarClase(String nombre, String descripcion)
        {
            Boolean resultado = false;
            _clase.Nombre = nombre;
            _clase.Descripcion = descripcion;
            _clase.Status = 0;
            resultado = _accesoClase.AgregarClase(_clase);
            //conectar a la bd

            return resultado;

        }


        #endregion


    }
}