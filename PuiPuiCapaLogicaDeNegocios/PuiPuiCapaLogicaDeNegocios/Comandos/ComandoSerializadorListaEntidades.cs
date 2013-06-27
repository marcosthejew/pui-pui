using PuiPuiCapaLogicaDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PuiPuiCapaLogicaDeNegocios.Comandos
{
    public class ComandoSerializadorListaEntidades:AComando<StringWriter>
    {
          StringWriter _cadenaSerializada= new StringWriter();
      public ComandoSerializadorListaEntidades(List<AEntidad> entidad)
        {
            StringWriter stringwriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(entidad.GetType());
            Type bkh=entidad.GetType();
            serializer.Serialize(stringwriter, entidad);
            _cadenaSerializada = stringwriter;
        }
        
        public override StringWriter Ejecutar()
        {
             
            return (_cadenaSerializada);
        }

    }
}
