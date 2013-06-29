using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaMusculo;
namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoAgregarMusculos:AComando<bool>

    {
        #region Atributos
        private string _nombre;
        private string _descripcion;
        #endregion

        #region Constructor
        public ComandoAgregarMusculos(String nombre, String descripcion)
        {
            _nombre = nombre;
            _descripcion = descripcion;
        }
        #endregion

        #region Metodo
        public override bool Ejecutar()
        {
            return new FachadaMusculos().ServicioAgregarMusculo(_nombre, _descripcion);
        }
        #endregion
    }
}