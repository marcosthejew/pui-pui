using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosInstructor
{
    public class ComandoSerializarInstructor : AComando<string>
    {
        List<AEntidad> _lista;
        AEntidad _entidad;
        
        public ComandoSerializarInstructor(List<AEntidad> lista)
        {
            _lista = lista;
        }
        public ComandoSerializarInstructor(AEntidad entidad)
        {
            _entidad = entidad;
        }

        public override string Ejecutar()
        {
            string retorno = "<Instructores>";
            if (_lista == null)
            {
                retorno += "<Instructor>";
                retorno += "<IdInstructor>" + (_entidad as Instructor).Id + "</IdInstructor>";
                retorno += "<Cedula>" + (_entidad as Instructor).CedulaPersona + "</Cedula>";
                retorno += "<PrimerNombre>" + (_entidad as Instructor).NombrePersona1 + "</PrimerNombre>";
                retorno += "<SegundoNombre>" + (_entidad as Instructor).NombrePersona2 + "</SegundoNombre>";
                retorno += "<PrimerApellido>" + (_entidad as Instructor).ApellidoPersona1 + "</PrimerApellido>";
                retorno += "<SegundoApellido>" + (_entidad as Instructor).ApellidoPersona2 + "</SegundoApellido>";
                retorno += "<Genero>" + (_entidad as Instructor).GeneroPersona + "</Genero>";
                retorno += "<FechaNacimiento>" + (_entidad as Instructor).FechaNacimientoPersona + "</FechaNacimiento>";
                retorno += "<FechaIngreso>" + (_entidad as Instructor).FechaIngresoPersona + "</FechaIngreso>";
                retorno += "<Entidad>" + (_entidad as Instructor).EstadoPersona + "</Entidad>";
                retorno += "<Ciudad>" + (_entidad as Instructor).CiudadPersona + "</Ciudad>";
                retorno += "<Direccion>" + (_entidad as Instructor).DireccionPersona + "</Direccion>";
                retorno += "<TelefonoLocal>" + (_entidad as Instructor).TelefonoLocalPersona + "</TelefonoLocal>";
                retorno += "<TelefonoCelular>" + (_entidad as Instructor).TelefonoCelularPersona + "</TelefonoCelular>";
                retorno += "<Correo>" + (_entidad as Instructor).CorreoPersona + "</Correo>";
                retorno += "<NombreContacto>" + (_entidad as Instructor).NombreContactoEmergencia + "</NombreContacto>";
                retorno += "<TelefonoContacto>" + (_entidad as Instructor).TelefonoContactoEmergencia + "</TelefonoContacto>";
                retorno += "<Status>" + 1 + "</Status>";
                retorno += "</Instructor>";
                
                retorno += "</Instructores>";
            }
            else
            {
                foreach (AEntidad instructor in _lista)
                {
                    retorno += "<Instructor>";
                    retorno += "<IdInstructor>" + (_entidad as Instructor).Id + "</IdInstructor>";
                    retorno += "<Cedula>" + (_entidad as Instructor).CedulaPersona + "</Cedula>";
                    retorno += "<PrimerNombre>" + (_entidad as Instructor).NombrePersona1 + "</PrimerNombre>";
                    retorno += "<SegundoNombre>" + (_entidad as Instructor).NombrePersona2 + "</SegundoNombre>";
                    retorno += "<PrimerApellido>" + (_entidad as Instructor).ApellidoPersona1 + "</PrimerApellido>";
                    retorno += "<SegundoApellido>" + (_entidad as Instructor).ApellidoPersona2 + "</SegundoApellido>";
                    retorno += "<Genero>" + (_entidad as Instructor).GeneroPersona + "</Genero>";
                    retorno += "<FechaNacimiento>" + (_entidad as Instructor).FechaNacimientoPersona + "</FechaNacimiento>";
                    retorno += "<FechaIngreso>" + (_entidad as Instructor).FechaIngresoPersona + "</FechaIngreso>";
                    retorno += "<Entidad>" + (_entidad as Instructor).EstadoPersona + "</Entidad>";
                    retorno += "<Ciudad>" + (_entidad as Instructor).CiudadPersona + "</Ciudad>";
                    retorno += "<Direccion>" + (_entidad as Instructor).DireccionPersona + "</Direccion>";
                    retorno += "<TelefonoLocal>" + (_entidad as Instructor).TelefonoLocalPersona + "</TelefonoLocal>";
                    retorno += "<TelefonoCelular>" + (_entidad as Instructor).TelefonoCelularPersona + "</TelefonoCelular>";
                    retorno += "<Correo>" + (_entidad as Instructor).CorreoPersona + "</Correo>";
                    retorno += "<NombreContacto>" + (_entidad as Instructor).NombreContactoEmergencia + "</NombreContacto>";
                    retorno += "<TelefonoContacto>" + (_entidad as Instructor).TelefonoContactoEmergencia + "</TelefonoContacto>";
                    retorno += "<Status>" + 1 + "</Status>";
                    retorno += "</Instructor>";
                }
                retorno += "</Instructores>";
            }
         return retorno;
        }
    }
}