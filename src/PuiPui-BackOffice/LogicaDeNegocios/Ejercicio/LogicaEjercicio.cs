﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades.Ejercicio;


namespace PuiPui_BackOffice.LogicaDeNegocios.Ejercicio
{
    public class LogicaEjercicio
    {


        public bool AgregarEjercicio(string nombre, String descripcion, int idmusculo)
        {
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            if (objDataBase.ExisteEjercicio(nombre))
            {
                return true;
            }
            else
            {
                return objDataBase.insertarEjercicio(nombre, descripcion, idmusculo);
            }

        }



        public List<Entidades.Ejercicio.Ejercicio> ConsultarTodosEjercicios()
        {
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            if (objDataBase.ConsultarEjercicios() != null)
            {
                return objDataBase.ConsultarEjercicios();
            }
            return null;    
        }



        public Entidades.Ejercicio.Ejercicio ConsultarEjercicio(string nombre)
        {
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            if (objDataBase.ConsultarEjercicio(nombre) != null)
            {
                return objDataBase.ConsultarEjercicio(nombre);
            }
            return null;
        }



    }
}