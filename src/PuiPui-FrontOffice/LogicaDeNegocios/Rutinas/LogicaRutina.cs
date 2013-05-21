﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.Entidades.Rutina;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades;
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

             public bool Update_Rutina(Rutina actualizar_rutina)
                     {
                       bool _updateo = false;
                    SQLServerRutina actualiza = new SQLServerRutina();
                    _updateo = actualiza.BDUpadteRutina(actualizar_rutina);
                    return _updateo= true;
   
                }


        public List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio> ConsultaTodoEjercicios()
        {
            List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio> _listaejercicios = new List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio>();
            PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio _ejercicios = new PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio();
            _listaejercicios = _ejercicios.ConsultarEjercicios();
            return _listaejercicios;

        
        
        }

        public List<int> Lista_Ejercicios_Historial(int id_cliente, int id_rutina)
        {
            List<int> ejercicios = new List<int>();
            SQLServerHistorialEjercicios _busca_ejercicios = new  SQLServerHistorialEjercicios();
            ejercicios = _busca_ejercicios.listaIdejercicios(id_cliente, id_rutina);
            return ejercicios;

        
        }

        public List<int> Lista_Rutinas_Historial(int id_cliente)
        {
            List<int> rutinas = new List<int>();
            SQLServerHistorialEjercicios _busca_ejercicios = new SQLServerHistorialEjercicios();
            rutinas = _busca_ejercicios.busca_id_rutina(id_cliente);
            return rutinas;


        }

        public bool Inserta_Historial(int id_cliente, int id_rutina, int id_ejercicio)
        {

            SQLServerHistorialEjercicios inserta_histo = new SQLServerHistorialEjercicios();
            bool _inserta = false;
            _inserta = inserta_histo.BDInsertarHistorial(id_cliente, id_rutina, id_ejercicio);
            return _inserta;
        
        
        }

        public bool Elimina_Historico(int cliente, int rutina)
        {
            bool _elimanada = false;
            SQLServerHistorialEjercicios _historial_eliminar = new SQLServerHistorialEjercicios();
            _elimanada = _historial_eliminar.BDEliminaHistorial(cliente, rutina);
            return _elimanada;
         
        }


        


        public Rutina Logirutina
        {
            get { return logirutina; }
            set { logirutina = value; }
        }
    }
}