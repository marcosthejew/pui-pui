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
        private string musculo;
         
        public ComandoModificarEjercicio(string nombre, string descripcion, string musculo)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.musculo = musculo;
        }
        public override bool Ejecutar()
        {
            
            return  new FachadaEjerciciosBackOffice().ServicioModificarEjercicio(nombre,descripcion,musculo);

        }

    }
}