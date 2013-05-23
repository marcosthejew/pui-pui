using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;
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

            String stat = null;
            DataTable miTabla = new DataTable();
            miTabla.Columns.Add("No.", typeof(string));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));
            try
            {

                _listaClase = _accesoClase.ConsultarClases();
                foreach (Clase clase in _listaClase)
                {
                    if (clase.Status == 1)
                    {
                        stat = "Activa";
                    }
                    else
                    {
                        stat = "Inactiva";
                    }
                    miTabla.Rows.Add(clase.IdClase, clase.Nombre, stat);
                }

            }
            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo consultar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return miTabla;
        }

        public Clase ObtenerDetalleClases(int id)
        {
            //conectar a la bd
            try
            {
                _clase = _accesoClase.DetalleClases(id);
            }
            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo consultar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }


            return _clase;
        }

        public List<Clase> ObtenerClases()
        {
            //conectar a la bd

            try
            {
                _listaClase = _accesoClase.ConsultarClases();
            }
            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo consultar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }

            return _listaClase;
        }

        public Boolean ModificarClase(Clase clase)
        {

            Boolean retorno = false;


            try
            {
                retorno = _accesoClase.ModificarClase(clase);
            }
            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo modificar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return retorno;

        }

        public Boolean AgregarClase(String nombre, String descripcion)
        {
            Boolean resultado = false;
            _clase.Nombre = nombre;
            _clase.Descripcion = descripcion;
            _clase.Status = 0;

            //conectar a la bd
            try
            {
                resultado = _accesoClase.AgregarClase(_clase);
            }
            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo Agregar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return resultado;

        }

        public DataTable ConsultarClasesNombre(String nombre)
        {
            DataTable miTabla = new DataTable();
            String stat = null;
            miTabla.Columns.Add("No", typeof(string));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));



            try
            {
                _listaClase = _accesoClase.BusquedaNombreClase(nombre);


                foreach (Clase clase in _listaClase)
                {
                    if (clase.Status == 1)
                    {
                        stat = "Activa";
                    }
                    else
                    {
                        stat = "Inactiva";
                    }
                    miTabla.Rows.Add(clase.IdClase, clase.Nombre, stat);
                }
            }
            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo consultar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return miTabla;

        }

        public DataTable ConsultarClaseStatus(int stat)
        {
            DataTable miTabla = new DataTable();
            String statu = null;
            miTabla.Columns.Add("No", typeof(string));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));



            try
            {
                _listaClase = _accesoClase.BusquedaStatusClase(stat);

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
            }
            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo consultar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return miTabla;
        }


        #endregion


    }
}