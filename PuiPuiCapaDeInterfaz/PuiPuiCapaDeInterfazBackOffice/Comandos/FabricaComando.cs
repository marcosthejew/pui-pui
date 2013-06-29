using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

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
        public static AComando<bool> CrearComandoCargarEjercicios(IContratoModificarEjercicio vista)
        {
            return new ComandoCargarEjercicio(vista);
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
        public static AComando<bool> CrearComandoDesactivarMusculo(int idMusuclo)
        {
            return new ComandoDesactivarMusculos(idMusuclo);
        }
        public static AComando<bool> CrearComandoModificarEjercicio(string nombre, string descripcion, string musculo)
        {
            return new ComandoModificarEjercicio(nombre,descripcion,musculo);
        }
    
        #endregion
    }
}