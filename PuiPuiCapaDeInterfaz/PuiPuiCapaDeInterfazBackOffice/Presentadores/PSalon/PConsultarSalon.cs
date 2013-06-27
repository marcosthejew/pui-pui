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
    /// <summary>
    /// Estalase tiene como finalidad realizar operaciones referentes a la 
    /// Vista de consultar salon con la capa de Logica de negocios.
    /// </summary>
    public class PConsultarSalon
    {
        IContratoConsultaSalon salon;
        
        public PConsultarSalon(IContratoConsultaSalon vista_Salon)
        {

            this.salon = vista_Salon;
        }


        /// <summary>
        /// Consulta todos los salonde gym que capa de datos pasando por la logica
        /// ya sea todos los salones o los salones por datos especificos 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable Consultar_salones()
        {
            DataTable tablaConsulta = new DataTable();
            tablaConsulta.Columns.Add("ID_Salon", typeof(string));
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
                     if(status1=="0")
                         status1="Activo";
                     else
                         status1="Inactivo";
                    tablaConsulta.Rows.Add(id1,codigo1, ubicacion1, capacidad1, status1);



                }
                return tablaConsulta;
            }
            
            if (salon.RBCapacidad == true)
            {
                FachadaSalonBackOfficeSoapClient consultaCapacidad = new FachadaSalonBackOfficeSoapClient();
                if (salon.DPLCapacidad.Trim() == "0")
                {
                   string CapacidadMayor = consultaCapacidad.ServicioComandoBusquedaCapacidadMayorSalon(salon.TxtCapacidad);
   
                XmlDocument salones = new XmlDocument();
                salones.LoadXml(CapacidadMayor);
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
                     if(status1=="0")
                         status1="Activo";
                     else
                         status1="Inactivo";
                    tablaConsulta.Rows.Add(id1,codigo1, ubicacion1, capacidad1, status1);



                }
                return tablaConsulta;
                }
                if (salon.DPLCapacidad.Trim() == "1")
                {
                    
                    string CapacidadMenor = consultaCapacidad.ServicioComandoBusquedaCapacidadMenorSalon(salon.TxtCapacidad);
        
                XmlDocument salones = new XmlDocument();
                salones.LoadXml(CapacidadMenor);
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
                     if(status1=="0")
                         status1="Activo";
                     else
                         status1="Inactivo";
                    tablaConsulta.Rows.Add(id1,codigo1, ubicacion1, capacidad1, status1);



                }
                return tablaConsulta;
                }

            }
            if (salon.RBUbicacion == true)
            {
                FachadaSalonBackOfficeSoapClient consultaUbicacion = new FachadaSalonBackOfficeSoapClient();
                string ConsultaUbicacion=consultaUbicacion.ServicioComandoUbicacionSalones(salon.TextNombreSalon);

                XmlDocument salones = new XmlDocument();
                salones.LoadXml(ConsultaUbicacion);
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
                     if(status1=="0")
                         status1="Activo";
                     else
                         status1="Inactivo";
                    tablaConsulta.Rows.Add(id1,codigo1, ubicacion1, capacidad1, status1);



                }
                return tablaConsulta;
            
            
            
            }
            if (salon.RBStatus == true)
            {
                FachadaSalonBackOfficeSoapClient consulta = new FachadaSalonBackOfficeSoapClient();
                if (salon.DPLStatus.Trim() == "0")
                {
                    string ConsultaStatus = consulta.ServicioComandoBusquedaStatusSalon(0);
      
                XmlDocument salones = new XmlDocument();
                salones.LoadXml(ConsultaStatus);
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
                     if(status1=="0")
                         status1="Activo";
                     else
                         status1="Inactivo";
                    tablaConsulta.Rows.Add(id1,codigo1, ubicacion1, capacidad1, status1);



                }
                return tablaConsulta;
                }
                else
                {

                    string ConsultaStatus = consulta.ServicioComandoBusquedaStatusSalon(1);
                  
                    XmlDocument salones = new XmlDocument();
                    salones.LoadXml(ConsultaStatus);
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
                         if(status1=="0")
                         status1="Activo";
                     else
                         status1="Inactivo";
                        tablaConsulta.Rows.Add(id1, codigo1, ubicacion1, capacidad1, status1);



                    }
                    return tablaConsulta;
               }

            
            }
        
            return tablaConsulta;
        }

    }
}