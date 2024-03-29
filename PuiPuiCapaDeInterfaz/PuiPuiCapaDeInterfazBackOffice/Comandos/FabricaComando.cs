﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosInstructor;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos
{
    /// <summary>
    /// Clase que instancia Comandos especificos casteados a la clase abstracta
    /// AComando.
    /// </summary>
    public class FabricaComando
    {
        #region Ejercicio
        public static AComando<bool> CrearComandoCargarMusculos(IAgregarEjercicio vista)
        {   
            return new ComandoCargarMusculos(vista);
        }
        public static AComando<bool> CrearComandoCargarMusculos(IContratoModificarEjercicio vista)
        {
            return new ComandoCargarMusculos(vista);
        }
        public static AComando<bool> CrearComandoCargarMusculos(IContratoDesactivarMusculo vista)
        {
            return new ComndoCargarMusculos2(vista);
        }
        public static AComando<bool> CrearComandoCargarEjercicios(IContratoConsultarEjercicio vista)
        {
            return new ComandoCargarEjercicio(vista);
        }
        public static AComando<bool> CrearComandoCargarEjercicios(IContratoDesactivarEjercicio vista)
        {
            return new ComandoCargarEjercicio(vista);
        }
        public static AComando<bool> CrearComandoCargarEjercicios(IContratoModificarEjercicio vista)
        {
            return new ComandoCargarEjercicio(vista);
        }
        public static AComando<bool> CrearComandoConsultarEjercicio(IContratoConsultarEjercicio vista)
        {
            return new ComandoConsultarEjercicio(vista);
        }
        public static AComando<bool> CrearComandoAgregarEjercicio(string nombre, string descripcion, string musculo)
        {
            return new ComandoAgregarEjercicio(nombre, descripcion, musculo);
        }
        public static AComando<bool> CrearComandoValidarCampo(string valor)
        {
            return new ComandoValidarCampo(valor);
        }
        public static AComando<bool> CrearComandoAgregarMusculo(string nombre, string descripcion)
        {
            return new ComandoAgregarMusculos(nombre, descripcion);
        }
        public static AComando<bool> CrearComandoDesactivarMusculo(int idMusuclo,string nombre)
        {
            return new ComandoDesactivarMusculos(idMusuclo,nombre);
        }
        public static AComando<bool> CrearComandoModificarEjercicio(string nombre, string descripcion, string musculo)
        {
            return new ComandoModificarEjercicio(nombre,descripcion,musculo);
        }
        public static AComando<bool> CrearComandoDesactivarEjercicio(int x,string nombre)
        {
            return new ComandoDesactivarEjercicio(0,nombre);
        }

    
        #endregion

        #region Instructor

        public static AComando<bool> CrearComandoCargarInstructores(IContratoConsultarInstructor vista)
        {
            return new ComandoCargarInstructor(vista);        
        }

        #endregion
    }
}