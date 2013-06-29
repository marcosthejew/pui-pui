using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.LogicaInstructor;
using PuiPuiCapaDeInterfazBackOffice.Vistas.VInstructor;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosInstructor
{
    public class ComandoCargarInstructor : AComando<bool>
    {
        IContratoConsultarInstructor _vista;

        public ComandoCargarInstructor(IContratoConsultarInstructor vista)
        {
            _vista = vista;
        }

        public override bool Ejecutar()
        {
            string instructores = new FachadaInstructor().ServicioConsultarTodosInstructor();
            XmlDocument instructor = new XmlDocument();
            instructor.LoadXml(instructores);
            XmlNodeList nodoInstructor = instructor.GetElementsByTagName("Instructores");
            XmlNodeList nodoListaInstructor = ((XmlElement)nodoInstructor[0]).GetElementsByTagName("Instructor");
            int i = 0;
            foreach (XmlElement nodo in nodoListaInstructor)
            {
                XmlNodeList id = nodo.GetElementsByTagName("IdInstructor");
                XmlNodeList cedula = nodo.GetElementsByTagName("Cedula");
                XmlNodeList primerNombre = nodo.GetElementsByTagName("PrimerNombre");
                XmlNodeList primerApellido = nodo.GetElementsByTagName("PrimerApellido");
                XmlNodeList status = nodo.GetElementsByTagName("Status");
                if (Convert.ToInt32(status[0].InnerText) == 1)
                {
                    (_vista as ConsultarInstructor).ListaInstructores.DataTextField = id[0].InnerText;
                    (_vista as ConsultarInstructor).ListaInstructores.DataTextField = cedula[0].InnerText;
                    (_vista as ConsultarInstructor).ListaInstructores.DataTextField = primerNombre[0].InnerText;
                    (_vista as ConsultarInstructor).ListaInstructores.DataTextField = primerApellido[0].InnerText;
                    (_vista as ConsultarInstructor).ListaInstructores.DataTextField = status[0].InnerText;

                    (_vista as ConsultarInstructor).ListaInstructores.Items.Insert(i, " " + cedula[0].InnerText + " " + primerNombre[0].InnerText + " " + primerApellido[0].InnerText);
                }
            }
            return true;
        }
    }
}