using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon;
using PuiPuiCapaDeInterfazBackOffice.LogicaSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon
{
    public class PConsultarSalon
    {
        IContratoConsultaSalon salon;
        private Vistas.VSalon.ConsultarSalon consultarSalon;
        public PConsultarSalon(IContratoConsultaSalon vista_Salon)
        {

            this.salon = vista_Salon;
        }



        public DataTable Consultar_salones()
        {
            DataTable tablaConsulta = new DataTable();
            tablaConsulta.Columns.Add("Codigo_Salon", typeof(string));
            tablaConsulta.Columns.Add("Ubicacion", typeof(string));
            tablaConsulta.Columns.Add("Capacidad", typeof(string));
            tablaConsulta.Columns.Add("Status", typeof(string));

            if (salon.RBConsultaCompleta == true)
            {
                FachadaSalonBackOfficeSoapClient consultaCompleta = new FachadaSalonBackOfficeSoapClient();
                string todos_salones = consultaCompleta.ServicioConsultarSalonesTodos();
                XmlDocument salones = new XmlDocument();
                salones.LoadXml(todos_salones);
                XmlNodeList classroom = salones.GetElementsByTagName("Salones");
                XmlNodeList listaSalon = ((XmlElement)classroom[0]).GetElementsByTagName("Salon");

                foreach (XmlElement nodo in listaSalon)
                {
                    int i = 0;
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList status = nodo.GetElementsByTagName("Status");
                    XmlNodeList capacidad = nodo.GetElementsByTagName("Capacidad");
                    XmlNodeList codigo = nodo.GetElementsByTagName("IdSalon");
                    XmlNodeList ubicacion = nodo.GetElementsByTagName("Ubicacion");
                    string id1 = id[i].InnerText;
                    string status1 = status[i].InnerText;
                    string capacidad1 = capacidad[i].InnerText;
                    string codigo1 = codigo[i].InnerText;
                    string ubicacion1 = ubicacion[i].InnerText;
                    tablaConsulta.Rows.Add(codigo1, ubicacion1, capacidad1, status1);



                }
                return tablaConsulta;
            }
            /*
            if (salon.RBCapacidad == true)
            {
                FachadaSalonBackOfficeSoapClient consultaCapacidad = new FachadaSalonBackOfficeSoapClient();
                if (salon.DPLCapacidad == "Mayor a")
                {
                    StringWriter CapacidadMayor = consultaCapacidad.ServicioComandoBusquedaCapacidadMayorSalon(salon.TxtCapacidad);
                }
                if (salon.DPLCapacidad == "Menor a")
                {

                    StringWriter CapacidadMenor = consultaCapacidad.ServicioComandoBusquedaCapacidadMenorSalon(salon.TxtCapacidad); 
                }

            }
            if (salon.RBUbicacion == true)
            {
                FachadaSalonBackOfficeSoapClient consultaUbicacion = new FachadaSalonBackOfficeSoapClient();
                StringWriter ConsultaUbicacion=consultaUbicacion.ServicioComandoUbicacionSalones(salon.TextNombreSalon);
            
            
            
            }
            if (salon.RBStatus == true)
            {
                FachadaSalonBackOfficeSoapClient consulta = new FachadaSalonBackOfficeSoapClient();
                if (salon.DPLStatus == "Activo")
                {
                    StringWriter ConsultaStatus = consulta.ServicioComandoBusquedaStatusSalon(0);
                }
                else
                {

                    StringWriter ConsultaStatus = consulta.ServicioComandoBusquedaStatusSalon(1);
               }

            
            }
        }*/
            return tablaConsulta;
        }

    }
}