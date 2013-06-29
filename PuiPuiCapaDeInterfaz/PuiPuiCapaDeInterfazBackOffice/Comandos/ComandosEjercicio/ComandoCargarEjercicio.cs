using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.LogicaEjercicios;
using PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;


namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoCargarEjercicio: AComando<bool>
    {
        IContratoConsultarEjercicio _vista;


        public ComandoCargarEjercicio(IContratoConsultarEjercicio vista)
        {
            _vista = vista;
        }
        public override bool Ejecutar()
        {

            string musculos = new FachadaEjerciciosBackOffice().ServicioConsultarEjercicioTodos();
            XmlDocument musculo = new XmlDocument();
            musculo.LoadXml(musculos);
            XmlNodeList nodoMusculo = musculo.GetElementsByTagName("Ejercicios");
            XmlNodeList nodoListaMusculo = ((XmlElement)nodoMusculo[0]).GetElementsByTagName("Ejercicio");
            int i = 0;
            foreach (XmlElement nodo in nodoListaMusculo)
            {

                XmlNodeList id = nodo.GetElementsByTagName("IdEjercicio");
                XmlNodeList nombre = nodo.GetElementsByTagName("NombreEjercicio");
                XmlNodeList status = nodo.GetElementsByTagName("Status");
                if (Convert.ToInt32(status[0].InnerText) == 1)
                {
                    (_vista as VistaConsultarEjercicio).Lista.DataTextField = id[0].InnerText;
                    (_vista as VistaConsultarEjercicio).Lista.DataTextField = nombre[0].InnerText;
                    (_vista as VistaConsultarEjercicio).Lista.Items.Insert(i, nombre[0].InnerText);
                }

            }
            return true;
        }
    }
}