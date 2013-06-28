using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoSerializarMusculo: AComando<string>
    {
        List<AEntidad> _lista;
        AEntidad _entidad;
        public ComandoSerializarMusculo(List<AEntidad> lista){
            _lista = lista;
        }
        public ComandoSerializarMusculo(AEntidad entidad)
        {
            _entidad = entidad;
        }
        public override string Ejecutar()
        {
            string retorno = "<Musculos>";
            if (_lista == null)
            {
                retorno += "<Musculo>";
                retorno += "<IdMusculo>" + (_entidad as Musculo).IdMusculo + "</IdMusculo>";
                retorno += "<NombreMusculo>" + (_entidad as Musculo).NombreMusculo + "</NombreMusculo>";
                retorno += "<Descripcion>" + (_entidad as Musculo).Descripcion + "</Descripcion>";
                retorno += "<Status>" + (_entidad as Musculo).Status + "</Status>";
                retorno += "</Musculo>";

                retorno += "</Musculos>";

            }
            else
            {

                foreach (AEntidad musculo in _lista)
                {
                    retorno += "<Musculo>";
                    retorno += "<IdMusculo>" + (musculo as Musculo).IdMusculo + "</IdMusculo>";
                    retorno += "<NombreMusculo>" + (musculo as Musculo).NombreMusculo + "</NombreMusculo>";
                    retorno += "<Descripcion>" + (musculo as Musculo).Descripcion + "</Descripcion>";
                    retorno += "<Status>" + (musculo as Musculo).Status + "</Status>";
                    retorno += "</Musculo>";

                }
                retorno += "</Musculos>";
            }
         return retorno;
        }
    }
}