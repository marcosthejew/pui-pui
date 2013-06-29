using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaEjercicios;
using PuiPuiCapaDeInterfazBackOffice.Contratos;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoModificarEjercicio:AComando<bool>
    {
        private string nombre;
        private string descripcion;
        public ComandoModificarEjercicio()
        {
           
        }
        public override bool Ejecutar()
        {
            
            return false ;
            //new FachadaEjerciciosBackOffice().ServicioModificarEjercicio(

        }

    }
}