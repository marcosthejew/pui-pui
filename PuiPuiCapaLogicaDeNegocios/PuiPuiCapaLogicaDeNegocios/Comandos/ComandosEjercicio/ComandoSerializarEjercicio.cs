using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoSerializarEjercicio:AComando<string>
    {
        List<AEntidad> _lista;
        AEntidad _entidad;
        public ComandoSerializarEjercicio(List<AEntidad> lista){
            _lista = lista;
        }
        public ComandoSerializarEjercicio(AEntidad entidad)
        {
            _entidad = entidad;
        }
        public override string Ejecutar()
        {
            string retorno = "<Ejercicios>";
            if (_lista == null)
            {
                retorno += "<Ejercicio>";
                retorno += "<IdEjercicio>" + (_entidad as Ejercicio).Id + "</IdEjercicio>";
                retorno += "<NombreEjercicio>" + (_entidad as Ejercicio).Nombre + "</NombreEjercicio>";
                retorno += "<Descripcion>" + (_entidad as Ejercicio).Descripcion + "</Descripcion>";
                retorno += "<IdMusculo>" + (_entidad as Ejercicio).Musculo.IdMusculo + "</IdMusculo>";
                retorno += "<NombreMusculo>" + (_entidad as Ejercicio).Musculo.NombreMusculo + "</NombreMusculo>";
                retorno += "<Status>" + (_entidad as Ejercicio).Status + "</Status>";
                retorno += "</Ejercicio>";
                
                retorno += "</Ejercicios>";

            }
            else
            {

                foreach (AEntidad ejercicio in _lista)
                {
                    retorno += "<Ejercicio>";
                    retorno += "<IdEjercicio>" + (ejercicio as Ejercicio).Id + "</IdEjercicio>";
                    retorno += "<NombreEjercicio>" + (ejercicio as Ejercicio).Nombre + "</NombreEjercicio>";
                    retorno += "<Descripcion>" + (ejercicio as Ejercicio).Descripcion + "</Descripcion>";
                    retorno += "<IdMusculo>" + (ejercicio as Ejercicio).Musculo.IdMusculo + "</IdMusculo>";
                    retorno += "<NombreMusculo>" + (ejercicio as Ejercicio).Musculo.NombreMusculo + "</NombreMusculo>";
                    retorno += "<Status>" + (ejercicio as Ejercicio).Status + "</Status>";
                    retorno += "</Ejercicio>";

                }
                retorno += "</Ejercicios>";
            }
         return retorno;
        }
    }
}