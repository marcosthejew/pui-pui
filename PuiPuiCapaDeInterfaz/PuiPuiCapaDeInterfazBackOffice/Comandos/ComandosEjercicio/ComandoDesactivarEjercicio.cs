using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaEjercicios;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoDesactivarEjercicio: AComando<bool>
    {
        #region Atributos
        private int _x;
        private string _nombre;
        #endregion

        #region Constructor
        public ComandoDesactivarEjercicio(int id, string nombre)
        {
            _x = id;
            _nombre = nombre;
        }
        #endregion

        #region Metodo
        public override bool Ejecutar()
        {
            return new FachadaEjerciciosBackOffice().ServicioInactivarEjercicio(0, _nombre);
        }
        #endregion

    }
}