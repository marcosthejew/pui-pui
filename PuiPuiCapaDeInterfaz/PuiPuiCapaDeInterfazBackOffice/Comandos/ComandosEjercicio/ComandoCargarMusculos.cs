using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.LogicaMusculo;
using PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;




namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoCargarMusculos : AComando<bool>
    {
        IAgregarEjercicio _vista;
        DropDownList _comboMusculo;

        public ComandoCargarMusculos(IAgregarEjercicio vista)
        {
            _vista = vista;
        }
        public override bool Ejecutar()
        {
            bool flag = true;

            string musculos = new FachadaMusculos().ServicioConsultarTodosLosMusculos();
            XmlDocument musculo = new XmlDocument();
            musculo.LoadXml(musculos);
            XmlNodeList nodoMusculo = musculo.GetElementsByTagName("Musculos");
            XmlNodeList nodoListaMusculo = ((XmlElement)nodoMusculo[0]).GetElementsByTagName("Musculo");
            int i = 0;
            foreach (XmlElement nodo in nodoListaMusculo)
            {
                
                XmlNodeList id = nodo.GetElementsByTagName("IdMusculo");
                XmlNodeList nombre = nodo.GetElementsByTagName("NombreMusculo");
                XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                XmlNodeList status = nodo.GetElementsByTagName("Status");
                if (Convert.ToInt32(status[0].InnerText) == 1)
                {
                    (_vista as VistaAgregarEjercicio).ComboMusculo.DataTextField = id[0].InnerText;
                    (_vista as VistaAgregarEjercicio).ComboMusculo.DataTextField = nombre[0].InnerText;
                    (_vista as VistaAgregarEjercicio).ComboMusculo.Items.Insert(i, nombre[0].InnerText);
                }

            }
            return flag;
        }
    }
}