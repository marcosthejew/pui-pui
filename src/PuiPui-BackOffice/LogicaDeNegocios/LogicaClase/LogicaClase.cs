﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
namespace PuiPui_BackOffice.LogicaDeNegocios.LogicaClase
{
    public class LogicaClase
    {

        #region Atributos

        private Clase _clase;
        private SQLServerClase _accesoClase;
        private List<Clase> _listaClase;
        #endregion

        #region Constructor

        public LogicaClase()
        {
            _clase = new Clase();
            _accesoClase = new SQLServerClase();

        }

        #endregion

        #region Metodos

        public DataTable ConsultarClase()
        {
            //conectar a la bd
            _listaClase = _accesoClase.ConsultarClases();
                         
            DataTable miTabla = new DataTable();
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Clase clase in _listaClase)
            {

                miTabla.Rows.Add(clase.IdClase, clase.Nombre, clase.Status);
            }

            return miTabla;
        }

            
        public Boolean ModificarClase(Clase clase)
        {

            Boolean retorno = false;

            retorno = _accesoClase.ModificarClase(clase);

            return retorno;

        }

        public Boolean AgregarClase(String nombre, String descripcion)
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