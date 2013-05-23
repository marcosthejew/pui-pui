﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.Entidades.Rutina;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;
using PuiPui_FrontOffice.Entidades;
namespace PuiPui_FrontOffice.LogicaDeNegocios.Rutinas

{
    public class LogicaRutina
    {
     
        private Rutina logirutina = new Rutina();

        /*Metodo para insertar una Rutina*/
        public bool InsertaRutina(string _descripcion, DateTime _duracion_rutina, int _repeticiones)
        {
           logirutina= new Rutina(_descripcion,_duracion_rutina, _repeticiones);
           SQLServerRutina _insertaRutina = new SQLServerRutina();
          bool _inserto = false;
          _inserto=_insertaRutina.BDInsertarRutina(logirutina);
          return _inserto;
        
        
        }

        /*Metodo para obtener  una Rutina*/

      
        public List<Rutina> ConsultaRutina(int id_rutina)
        {
            List<Rutina> _rutinas = new List<Rutina>();
            SQLServerRutina _insertaRutina = new SQLServerRutina();
            _rutinas = _insertaRutina.BDConsultaRutinas(id_rutina);
            return _rutinas;
        
        }

        /*Metodo para updatear una Rutina*/

        public bool Update_Rutina(Rutina actualizar_rutina)
                     {
                       bool _updateo = false;
                    SQLServerRutina actualiza = new SQLServerRutina();
                    _updateo = actualiza.BDUpadteRutina(actualizar_rutina);
                    return _updateo= true;
   
                }

         /*Metodo para tener datos de un ejercicio por nombre */
        public PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio BuscaDatos_Ejercicio (string nombre)
    {
        PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio ejercicio = new PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio();
       PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio datos_ejercicio = new PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio();
       datos_ejercicio = ejercicio.ConsultarEjercicio(nombre);
       return datos_ejercicio;
       
    }
        /*Metodo para cargar todos los ejercicios disponibles en la BD */
        public List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio> ConsultaTodoEjercicios()
        {
            List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio> _listaejercicios = new List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio>();
            PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio _ejercicios = new PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio();
            _listaejercicios = _ejercicios.ConsultarEjercicios();
            return _listaejercicios;

        
        
        }

        /* Metodo para traer las id de los ejercicios por rutina */
        public List<Historial_Ejercicio> Lista_Ejercicios_Historial(int id_cliente, int id_rutina)
        {
            List<Historial_Ejercicio> ejercicios = new List<Historial_Ejercicio>();
            SQLServerHistorialEjercicios _busca_ejercicios = new  SQLServerHistorialEjercicios();
            ejercicios = _busca_ejercicios.listaIdejercicios(id_cliente, id_rutina);
            return ejercicios;

        
        }

        /* Metodo para traer las id de  rutina por el id del cliente */
        public List<Historial_Ejercicio> Lista_Rutinas_Historial(int id_cliente)
        {
            List<Historial_Ejercicio> rutinas = new List<Historial_Ejercicio>();
            SQLServerHistorialEjercicios _busca_ejercicios = new SQLServerHistorialEjercicios();
            rutinas = _busca_ejercicios.busca_id_rutina(id_cliente);
            return rutinas;


        }

        /*Metodo para insertar en la tabla Historial Cliente*/
        public bool Inserta_Historial(int id_cliente, int id_rutina, int id_ejercicio)
        {

            SQLServerHistorialEjercicios inserta_histo = new SQLServerHistorialEjercicios();
            bool _inserta = false;
            _inserta = inserta_histo.BDInsertarHistorial(id_cliente, id_rutina, id_ejercicio);
            return _inserta;
        
        
        }
        
        /*Metodo para eliminar rutinas en el Historial de los CLientes */
        public bool Elimina_Historico(int cliente, int rutina)
        {
            bool _elimanada = false;
            SQLServerHistorialEjercicios _historial_eliminar = new SQLServerHistorialEjercicios();
            _elimanada = _historial_eliminar.BDEliminaHistorial(cliente, rutina);
            return _elimanada;
         
        }


        public Rutina Devuelve_Ultimo_ID()
        {
            Rutina find_id = new Rutina();
            SQLServerRutina busca_id= new SQLServerRutina();
            find_id = busca_id.BDUltimo_ID_Rutina();
            return find_id;
        
        }
        public Entidades.Ejercicio.Ejercicio BuscaIDEjercicio(string nombre_ejercicio)
        {
            Entidades.Ejercicio.Ejercicio ejercicio = new Entidades.Ejercicio.Ejercicio();
            SQLServerEjercicio busca_ejercicio = new    SQLServerEjercicio();
            ejercicio = busca_ejercicio.ConsultarEjercicio(nombre_ejercicio);
            return ejercicio;
        
        
        }
        public Entidades.Cliente.Persona BuscaIDNombrePersona(string nombre_persona)
        {
            Entidades.Cliente.Persona persona = new Entidades.Cliente.Clientes();
            SQLServerPersona busca_persona = new SQLServerPersona();
            persona = busca_persona.ConsultarPersonaPorLogin(nombre_persona);
            return persona;


        }





        public Rutina Logirutina
        {
            get { return logirutina; }
            set { logirutina = value; }
        }
    }
}