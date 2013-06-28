using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaEjercicios;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoAgregarEjercicio:AComando<bool>
    {
        private string _nombre;
        private string _descripcion;
        private string _musculo;
        public ComandoAgregarEjercicio(string nombre, string descripcion, string musculo)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _musculo = musculo;
        }
        public override bool Ejecutar()
        {
            return new FachadaEjerciciosBackOffice().ServicioAgregarEjercicio(_nombre,_descripcion,0,_nombre);
        }
    }
}