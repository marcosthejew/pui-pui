using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;

namespace PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon
{
    public class LogicaSalon
    {

        #region Atributos

        private Salon _salon;
        private SQLServerSalon _accesoSalon;
        private SQLServerClaseSalon _accesoSalonClase;
        private List<Salon> _miLista;
        private List<ClaseSalon> _listaGrande;

        #endregion

        #region Constructor

        public LogicaSalon()
        {
            _salon = new Salon();
            _accesoSalon = new SQLServerSalon();
            _miLista = new List<Salon>();
            _listaGrande = new List<ClaseSalon>();
            _accesoSalonClase = new SQLServerClaseSalon();
        }

        #endregion

        #region Metodos Salon

        public DataTable ConsultarSalones()
        {
            DataTable miTabla = new DataTable();
            String stat = null;

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));


            try
            {
                _miLista = _accesoSalon.ConsultarSalones();

                foreach (Salon salon in _miLista)
                {
                    if (salon.Status == 1)
                    {
                        stat = "Activo";
                    }
                    else
                    {
                        stat = "Inactivo";
                    }
                    miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, stat);
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

        public List<Salon> ObtenerSalones()
        {
            //conectar a la bd

            try
            {
                _miLista = _accesoSalon.ConsultarSalones();
            }

            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo consultar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return _miLista;
        }

        public Boolean ModificarSalones(Salon salon)
        {

            Boolean retorno = false;


            try
            {
                retorno = _accesoSalon.ModificarSalon(salon);
            }

            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo Modificar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return retorno;

        }

        public Boolean AgregarSalones(String ubicacion, int capacidad)
        {
            Boolean resultado = false;
            _salon.Ubicacion = ubicacion;
            _salon.Capacidad = capacidad;
            _salon.Status = 0;

            //conectar a la bd
            try
            {
                resultado = _accesoSalon.AgregarSalon(_salon);
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

        public DataTable ConsultarSalonesUbicacion(String ubi)
        {
            DataTable miTabla = new DataTable();
            String stat = null;
            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            try
            {
                _miLista = _accesoSalon.BusquedaUbicacion(ubi);


                foreach (Salon salon in _miLista)
                {
                    if (salon.Status == 1)
                    {
                        stat = "Activo";
                    }
                    else
                    {
                        stat = "Inactivo";
                    }
                    miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, stat);
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

        public DataTable ConsultarSalonesCapacidadMayo(int capa)
        {
            DataTable miTabla = new DataTable();
            String stat = null;
            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));


            try
            {
                _miLista = _accesoSalon.BusquedaCapacidadMayorSalon(capa);

                foreach (Salon salon in _miLista)
                {
                    if (salon.Status == 1)
                    {
                        stat = "Activo";
                    }
                    else
                    {
                        stat = "Inactivo";
                    }
                    miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, stat);
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

        public DataTable ConsultarSalonesCapacidadMenor(int capa)
        {
            DataTable miTabla = new DataTable();
            String stat = null;
            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));


            try
            {
                _miLista = _accesoSalon.BusquedaCapacidadMenorSalon(capa);


                foreach (Salon salon in _miLista)
                {
                    if (salon.Status == 1)
                    {
                        stat = "Activo";
                    }
                    else
                    {
                        stat = "Inactivo";
                    }
                    miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, stat);
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

        public DataTable ConsultarSalonesStatus(int stat)
        {
            DataTable miTabla = new DataTable();
            String statu = null;
            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));


            try
            {
                _miLista = _accesoSalon.BusquedaStatusSalon(stat);


                foreach (Salon salon in _miLista)
                {
                    if (salon.Status == 1)
                    {
                        statu = "Activo";
                    }
                    else
                    {
                        statu = "Inactivo";
                    }
                    miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, statu);
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

        #region Metodos Clase Salon Instructor

        public DataTable ConsultarSalonesClase()
        {
            DataTable miTabla = new DataTable();

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));


            try
            {
                _miLista = _accesoSalon.ConsultarSalones();

                foreach (Salon salon in _miLista)
                {

                    miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
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

        public List<ClaseSalon> SalonesClase()
        {
            DataTable miTabla = new DataTable();


            try
            {
                _listaGrande = _accesoSalonClase.ListarSalonesClase();
            }

            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo consultar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }

            return _listaGrande;
        }

        public Boolean ModificarSalonesClase(ClaseSalon salon)
        {

            Boolean retorno = false;


            try
            {
                retorno = _accesoSalonClase.ModificarSalonClase(salon);
            }

            catch (ExecpcionClaseSalon e)
            {

                throw new ExecpcionClaseSalon("No se pudo Modificar en la BD", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionClaseSalonLogica("Objetos vacios para la consulta", e);
            }
            return retorno;

        }

        public Boolean AgregarSalonesClase(int idclas, int idins, int idsa)
        {
            Boolean resultado = false;

            ClaseSalon newclase = new ClaseSalon();

            newclase.Clase.IdClase = idclas;
            newclase.Salon.IdSalon = idsa;
            newclase.Instructor.IdPersona = idsa;
            _salon.Status = 0;

            //conectar a la bd
            try
            {
                resultado = _accesoSalonClase.AgregarClaseSalon(newclase);
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

        public DataTable ConsultarSalonesClasePorClase(String clase)
        {
            DataTable miTabla = new DataTable();

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));


            try
            {
                _listaGrande = _accesoSalonClase.ListarSalonesClaseTclase(clase);


                String stat;
                foreach (ClaseSalon salon in _listaGrande)
                {
                    if (salon.Disponibilidad == 1)
                    {
                        stat = "Activa";
                    }
                    else
                    {
                        stat = "Inactiva";
                    }
                    miTabla.Rows.Add(salon.Id, salon.Clase.Nombre, salon.Salon.Ubicacion, salon.Instructor.NombrePersona1 + salon.Instructor.ApellidoPersona1, stat);
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

        public DataTable ConsultarSalonesClasePorUbicacion(String ubi)
        {
            DataTable miTabla = new DataTable();

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));
            String stat;

            try
            {
                _listaGrande = _accesoSalonClase.ListarSalonesClaseTsalon(ubi);

                foreach (ClaseSalon salon in _listaGrande)
                {
                    if (salon.Disponibilidad == 1)
                    {
                        stat = "Activa";
                    }
                    else
                    {
                        stat = "Inactiva";
                    }
                    miTabla.Rows.Add(salon.Id, salon.Clase.Nombre, salon.Salon.Ubicacion, salon.Instructor.NombrePersona1 + salon.Instructor.ApellidoPersona1, stat);
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

        public DataTable ConsultarSalonesClasePorInstructor(String ins)
        {
            DataTable miTabla = new DataTable();

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));


            try
            {
                _listaGrande = _accesoSalonClase.ListarSalonesClaseTinstructor(ins);

                String stat;
                foreach (ClaseSalon salon in _listaGrande)
                {
                    if (salon.Disponibilidad == 1)
                    {
                        stat = "Activa";
                    }
                    else
                    {
                        stat = "Inactiva";
                    }
                    miTabla.Rows.Add(salon.Id, salon.Clase.Nombre, salon.Salon.Ubicacion, salon.Instructor.NombrePersona1 + salon.Instructor.ApellidoPersona1, stat);
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

        public DataTable ConsultarSalonesClasePorEstatus(int st)
        {
            DataTable miTabla = new DataTable();

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            try
            {
                _listaGrande = _accesoSalonClase.ListarSalonesClaseTdisponible(st);

                String stat;
                foreach (ClaseSalon salon in _listaGrande)
                {
                    if (salon.Disponibilidad == 1)
                    {
                        stat = "Activa";
                    }
                    else
                    {
                        stat = "Inactiva";
                    }
                    miTabla.Rows.Add(salon.Id, salon.Clase.Nombre, salon.Salon.Ubicacion, salon.Instructor.NombrePersona1 + salon.Instructor.ApellidoPersona1, stat);
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