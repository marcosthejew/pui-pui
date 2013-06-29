using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.LogicaEjercicios;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
  
namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoConsultarEjercicio:AComando<bool>
    {
        private IContratoConsultarEjercicio _vista;
        public ComandoConsultarEjercicio(IContratoConsultarEjercicio vista)
        {
            _vista = vista;
        }
        public override bool Ejecutar()
        {
            string ejercicios = new FachadaEjerciciosBackOffice().ServicioConsultarEjercicioTodos();
            XmlDocument ejercicio = new XmlDocument();
            ejercicio.LoadXml(ejercicios);
            XmlNodeList nodoEjercicio = ejercicio.GetElementsByTagName("Ejercicios");
            XmlNodeList nodoListaEjercicio = ((XmlElement)nodoEjercicio[0]).GetElementsByTagName("Ejercicio");
            int i = 0;
            foreach (XmlElement nodo in nodoListaEjercicio)
            {

                XmlNodeList id = nodo.GetElementsByTagName("IdEjercicio");
                XmlNodeList nombre = nodo.GetElementsByTagName("NombreEjercicio");
                XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                XmlNodeList musculo = nodo.GetElementsByTagName("NombreMusculo");
                XmlNodeList status = nodo.GetElementsByTagName("Status");
                if (Convert.ToInt32(status[0].InnerText) == 1)
                {
                    _vista.NombreEjercicio = nombre[0].InnerText;;
                    _vista.DescripcionMusculo = descripcion[0].InnerText;
                    _vista.MusculoAEjercitar = musculo[0].InnerText;
                }

            }
            return true;
        }

    }
}