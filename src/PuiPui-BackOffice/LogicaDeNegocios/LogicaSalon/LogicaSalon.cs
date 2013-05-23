using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;

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
            _miLista= new List<Salon>();
            _listaGrande = new List<ClaseSalon>();
            _accesoSalonClase= new SQLServerClaseSalon();
        }

        #endregion

        #region Metodos Salon

        public DataTable ConsultarSalones()
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.ConsultarSalones();
            String stat = null; 

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

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

            return miTabla;
        }

        public List<Salon> ObtenerSalones()
        {
            //conectar a la bd
            _miLista = _accesoSalon.ConsultarSalones();
            return _miLista;
        }
        
        public Boolean ModificarSalones(Salon salon)
        {

            Boolean retorno = false;

            retorno = _accesoSalon.ModificarSalon(salon);

            return retorno;

        }

        public Boolean AgregarSalones(String ubicacion, int capacidad)
        {
            Boolean resultado = false;
            _salon.Ubicacion = ubicacion;
            _salon.Capacidad = capacidad;
            _salon.Status = 0;
            resultado = _accesoSalon.AgregarSalon(_salon);
            //conectar a la bd

            return resultado;

        }

        public DataTable ConsultarSalonesUbicacion(String ubi)
        {
            DataTable miTabla = new DataTable();
            String stat = null;

            _miLista = _accesoSalon.BusquedaUbicacion(ubi);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

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

            return miTabla;
        }

        public DataTable ConsultarSalonesCapacidadMayo(int capa)
        {
            DataTable miTabla = new DataTable();
            String stat = null;

            _miLista = _accesoSalon.BusquedaCapacidadMayorSalon(capa);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

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

            return miTabla;
        }

        public DataTable ConsultarSalonesCapacidadMenor(int capa)
        {
            DataTable miTabla = new DataTable();
            String stat = null;

            _miLista = _accesoSalon.BusquedaCapacidadMenorSalon(capa);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

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

            return miTabla;
        }

        public DataTable ConsultarSalonesStatus(int stat)
        {
            DataTable miTabla = new DataTable();
            String statu = null;

            _miLista = _accesoSalon.BusquedaStatusSalon(stat);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

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

            return miTabla;
        }

        #endregion

        #region Metodos Clase Salon Instructor

        public DataTable ConsultarSalonesClase()
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.ConsultarSalones();

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
            }

            return miTabla;
        }

        public List<ClaseSalon> SalonesClase()
        {
            DataTable miTabla = new DataTable();

            _listaGrande = _accesoSalonClase.ListarSalonesClase();

            
            return _listaGrande;
        }

        public Boolean ModificarSalonesClase(Salon salon)
        {

            Boolean retorno = false;

            retorno = _accesoSalon.ModificarSalon(salon);

            return retorno;

        }

        public Boolean AgregarSalonesClase(int idclas, int idins, int idsa)
        {
            Boolean resultado = false;

            ClaseSalon newclase= new ClaseSalon( );

            newclase.Clase.IdClase=idclas;
            newclase.Salon.IdSalon=idsa;
            newclase.Instructor.IdPersona=idsa;
            _salon.Status = 0;
            resultado = _accesoSalonClase.AgregarClaseSalon(newclase);
            //conectar a la bd

            return resultado;

        }

        public DataTable ConsultarSalonesClasePorClase(String clase)
        {
            DataTable miTabla = new DataTable();

            _listaGrande = _accesoSalonClase.ListarSalonesClaseTclase(clase);

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

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

            return miTabla;
        }

        public DataTable ConsultarSalonesClasePorUbicacion(String ubi)
        {
            DataTable miTabla = new DataTable();

            _listaGrande = _accesoSalonClase.ListarSalonesClaseTsalon(ubi);

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));
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
            return miTabla;
        }

        public DataTable ConsultarSalonesClasePorInstructor(String ins)
        {
            DataTable miTabla = new DataTable();

            _listaGrande = _accesoSalonClase.ListarSalonesClaseTinstructor(ins);

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

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

            return miTabla;
        }

        public DataTable ConsultarSalonesClasePorEstatus(int st)
        {
            DataTable miTabla = new DataTable();

            _listaGrande = _accesoSalonClase.ListarSalonesClaseTdisponible(st);

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));
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

            return miTabla;
        }

        #endregion
    }
}