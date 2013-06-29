using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaMusculo;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoDesactivarMusculos:AComando<bool>
    {
        private int _idMusculo;
        private string _nombre;

        public ComandoDesactivarMusculos(int idMusculo, string nombre)
        {
            _idMusculo = idMusculo;
            _nombre = nombre;

        }

        public override bool Ejecutar()
        {
            return new FachadaMusculos().ServicioDesactivarMusculo(0,_nombre);
        }
    }
}