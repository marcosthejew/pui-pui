using System;
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
            String stat=null;             
            DataTable miTabla = new DataTable();
            miTabla.Columns.Add("No.", typeof(string));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Clase clase in _listaClase)
            {
                if (clase.Status==1)
                {
                    stat="Activa";
                }
                else
                {
                    stat = "Inactiva";
                }
                miTabla.Rows.Add(clase.IdClase, clase.Nombre, stat);
            }

            return miTabla;
        }

        public Clase ObtenerDetalleClases(int id)
        {
            //conectar a la bd
            _clase = _accesoClase.DetalleClases(id);

            return _clase;
        }

        public List<Clase> ObtenerClases()
        {
            //conectar a la bd
            _listaClase = _accesoClase.ConsultarClases();


            return _listaClase;
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

        public DataTable ConsultarClasesNombre(String nombre)
        {
            DataTable miTabla = new DataTable();
            String stat = null; 

            _listaClase = _accesoClase.BusquedaNombreClase(nombre);

            miTabla.Columns.Add("No", typeof(string));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));
            
            foreach (Clase clase in _listaClase)
            {
                if (clase.Status==1)
                {
                    stat="Activa";
                }
                else
                {
                    stat = "Inactiva";
                }
                miTabla.Rows.Add(clase.IdClase, clase.Nombre, stat);
            }              
           
            return miTabla;
            
        }

        public DataTable ConsultarClaseStatus(int stat)
        {
            DataTable miTabla = new DataTable();
            String statu = null;

            _listaClase = _accesoClase.BusquedaStatusClase(stat);

            miTabla.Columns.Add("No", typeof(string));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Clase clase in _listaClase)
            {
                if (clase.Status == 1)
                {
                    statu = "Activa";
                }
                else
                {
                    statu = "Inactiva";
                }
                miTabla.Rows.Add(clase.IdClase, clase.Nombre, statu);
            }

            return miTabla;
        }
       

        #endregion


    }
}