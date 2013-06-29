using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoDesSerializarStatus : AComando<string>
    {
        string status;

        public ComandoDesSerializarStatus(string _status)
        {
            this.status = _status;
        }
        public override string Ejecutar()
        {
            try
            {
                
                XmlDocument xml = new XmlDocument();
                xml.Load(new System.IO.StringReader(status));
                XmlNodeList statuss = xml.GetElementsByTagName("Rutina");
                XmlNodeList xnList = ((XmlElement)statuss[0]).GetElementsByTagName("Status");
                int l = 0;
                
                   // XmlNodeList statusss = nodo.GetElementsByTagName("Status");

                string status1 = xnList[l].InnerText;

                    status = status1;
                
                
                // return new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().ConsultarRutinasPorIDCliente(rutina);
                

                return status;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}