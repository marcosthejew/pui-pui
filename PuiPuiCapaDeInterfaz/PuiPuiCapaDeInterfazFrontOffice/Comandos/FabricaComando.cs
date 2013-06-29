using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos
{
    /// <summary>
    /// Clase que instancia Comandos especificos casteados a la clase abstracta
    /// AComando.
    /// </summary>
    public class FabricaComando
    {

        #region Rutinas Patricia

        public static AComando<string> CrearComandoConsultarRutina(int idCliente)
        {
            return new ComandoConsultarRutina(idCliente);
           
        }

        public static AComando<DataTable> CrearComandoDesSerializarRutina(string rutina)
        {
            return new ComandoDesSerializarRutina(rutina);
        }

        public static AComando<string> CrearComandoStatusDeRutina(int idRutina)
        {
            return new ComandoStatusDeRutina(idRutina);
        }
        public static AComando<bool> CrearComandoActivarInactivarRutina(int idRutina, byte inactivo)
        {
            return new ComandoActivarInactivarRutina(idRutina, inactivo);
        }

        public static AComando<string> CrearComandoDesSerializarStatus(string resultadoComando)
        {
            return new ComandoDesSerializarStatus(resultadoComando);
        }
        #endregion        

        #region Angelica

        public static AComando<string> CrearComandoConsultarEjerciciosTodos()
        {
            return new ComandoConsultarEjercicios();

        }

        public static AComando<DataTable> CrearComandoDeserializarEjercicio(string resultado)
        {
            return new ComandoDeserializarEjercicio(resultado);
        }


        public static AComando<bool> CrearComandoAgregarRutina(string nombre, string descripcion)
        {
            return new ComandoAgregarRutina(nombre, descripcion);
        }



        #endregion


    }
}