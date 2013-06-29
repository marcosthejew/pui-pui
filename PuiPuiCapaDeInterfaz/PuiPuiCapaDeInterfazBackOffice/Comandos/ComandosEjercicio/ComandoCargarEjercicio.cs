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
        IContratoModificarEjercicio _vista2;


        public ComandoCargarEjercicio(IContratoConsultarEjercicio vista)
        {
            _vista = vista;
        }
        public ComandoCargarEjercicio(IContratoModificarEjercicio vista)
        {
            _vista2 = vista;
        }
        public override bool Ejecutar()
        {
            if (_vista!=null)
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
                    XmlNodeList status = nodo.GetElementsByTagName("Status");
                    if (Convert.ToInt32(status[0].InnerText) == 1)
                    {
                        (_vista as VistaConsultarEjercicio).Lista.DataTextField = id[0].InnerText;
                        (_vista as VistaConsultarEjercicio).Lista.DataTextField = nombre[0].InnerText;
                        (_vista as VistaConsultarEjercicio).Lista.Items.Insert(i, nombre[0].InnerText);
                    }

                }
            }
            else
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
                    XmlNodeList status = nodo.GetElementsByTagName("Status");
                    if (Convert.ToInt32(status[0].InnerText) == 1)
                    {
                        (_vista as VistaModificarEjercicio).ListaEjercicio.DataTextField = id[0].InnerText;
                        (_vista as VistaModificarEjercicio).ListaEjercicio.DataTextField = nombre[0].InnerText;
                        (_vista as VistaModificarEjercicio).ListaEjercicio.Items.Insert(i, nombre[0].InnerText);
                    }

                }
            }
            return true;
        }
    }
}