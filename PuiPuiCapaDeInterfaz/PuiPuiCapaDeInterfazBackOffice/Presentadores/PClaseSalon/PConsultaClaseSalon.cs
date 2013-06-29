using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClaseSalon;
using PuiPuiCapaDeInterfazBackOffice.LogicaClaseSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PClaseSalon
{
    public class PConsultaClaseSalon
    {
        IContratoConsultarClaseSalon consultar;
        public PConsultaClaseSalon(IContratoConsultarClaseSalon vistaConsulta)
        {

            this.consultar = vistaConsulta;
        }
        public DataTable Consulta()
        {
            FachadaClaseSalonBackOfficeSoapClient consulta = new FachadaClaseSalonBackOfficeSoapClient();
            DataTable tablaConsulta = new DataTable();
            tablaConsulta.Columns.Add("ID_ClaseSalon", typeof(string));
            tablaConsulta.Columns.Add("Clase", typeof(string));
            tablaConsulta.Columns.Add("Codigo Salon", typeof(string));
            tablaConsulta.Columns.Add("Ubicacion", typeof(string));
            tablaConsulta.Columns.Add("Instructor", typeof(string));
            tablaConsulta.Columns.Add("Hora Inicio", typeof(string));
            tablaConsulta.Columns.Add("Hora Fin", typeof(string));
            tablaConsulta.Columns.Add("Status", typeof(string));

            if (consultar.RBTodos == true)
            {
                string listaConsulta = consulta.ServicioConsultarClaseSalonTodos();
                XmlDocument consultas= new XmlDocument();
                consultas.LoadXml(listaConsulta);
                XmlNodeList classroom = consultas.GetElementsByTagName("ClasesSalon");
                XmlNodeList listaCS = ((XmlElement)classroom[0]).GetElementsByTagName("ClaseSalon");

                foreach (XmlElement nodo in listaCS)

                { 
                 int i = 0;
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList clase = nodo.GetElementsByTagName("Clase");
                    XmlNodeList codigo = nodo.GetElementsByTagName("Codigo");
                    XmlNodeList ubicacion = nodo.GetElementsByTagName("Ubicacion");
                    XmlNodeList instructor = nodo.GetElementsByTagName("Instructor");
                    XmlNodeList horainicio = nodo.GetElementsByTagName("HInicio");
                    XmlNodeList horafin = nodo.GetElementsByTagName("HFin");
                    XmlNodeList status = nodo.GetElementsByTagName("Estatus");
                   
                    string id1 = id[i].InnerText;
                    string clase1 = clase[i].InnerText;
                    string codigo1 = codigo[i].InnerText;
                    string ubicacion1 = ubicacion[i].InnerText;
                    string instructor1 = instructor[i].InnerText;
                    string horainicio1 = horainicio[i].InnerText;
                    string horafin1 = horafin[i].InnerText;
                    string status1 = status[i].InnerText;
                                
                    if (status1 == "0")
                        status1 = "Activo";
                    else
                        status1 = "Inactivo";
                    tablaConsulta.Rows.Add(id1, clase1, codigo1, ubicacion1, instructor1, horainicio1, horafin1, status1);

                
                }
                return tablaConsulta;
            }
            if (consultar.RBClase == true)
            {
                string listaConsulta = consulta.ServicioConsultarPorClase(consultar.TXTClase);
                XmlDocument consultas = new XmlDocument();
                consultas.LoadXml(listaConsulta);
                XmlNodeList classroom = consultas.GetElementsByTagName("ClasesSalon");
                XmlNodeList listaCS = ((XmlElement)classroom[0]).GetElementsByTagName("ClaseSalon");

                foreach (XmlElement nodo in listaCS)
                {
                    int i = 0;
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList clase = nodo.GetElementsByTagName("Clase");
                    XmlNodeList codigo = nodo.GetElementsByTagName("Codigo");
                    XmlNodeList ubicacion = nodo.GetElementsByTagName("Ubicacion");
                    XmlNodeList instructor = nodo.GetElementsByTagName("Instructor");
                    XmlNodeList horainicio = nodo.GetElementsByTagName("HInicio");
                    XmlNodeList horafin = nodo.GetElementsByTagName("HHFin");
                    XmlNodeList status = nodo.GetElementsByTagName("Status");

                    string id1 = id[i].InnerText;
                    string status1 = status[i].InnerText;
                    string codigo1 = codigo[i].InnerText;
                    string clase1 = clase[i].InnerText;
                    string ubicacion1 = ubicacion[i].InnerText;
                    string instructor1 = instructor[i].InnerText;
                    string horainicio1 = horainicio[i].InnerText;
                    string horafin1 = horafin[i].InnerText;
                    if (status1 == "0")
                        status1 = "Activo";
                    else
                        status1 = "Inactivo";
                    tablaConsulta.Rows.Add(id1, clase1, codigo1, ubicacion1, instructor1, horainicio1, horafin1, status1);


                }
                return tablaConsulta;
            
            }
            if (consultar.RBSalon== true)
            {
                string listaConsulta = consulta.ServicioConsultarPorSalon(consultar.TXTSalon);
                XmlDocument consultas = new XmlDocument();
                consultas.LoadXml(listaConsulta);
                XmlNodeList classroom = consultas.GetElementsByTagName("ClasesSalon");
                XmlNodeList listaCS = ((XmlElement)classroom[0]).GetElementsByTagName("ClaseSalon");

                foreach (XmlElement nodo in listaCS)
                {
                    int i = 0;
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList clase = nodo.GetElementsByTagName("Clase");
                    XmlNodeList codigo = nodo.GetElementsByTagName("Codigo");
                    XmlNodeList ubicacion = nodo.GetElementsByTagName("Ubicacion");
                    XmlNodeList instructor = nodo.GetElementsByTagName("Instructor");
                    XmlNodeList horainicio = nodo.GetElementsByTagName("HInicio");
                    XmlNodeList horafin = nodo.GetElementsByTagName("HHFin");
                    XmlNodeList status = nodo.GetElementsByTagName("Status");

                    string id1 = id[i].InnerText;
                    string status1 = status[i].InnerText;
                    string codigo1 = codigo[i].InnerText;
                    string clase1 = clase[i].InnerText;
                    string ubicacion1 = ubicacion[i].InnerText;
                    string instructor1 = instructor[i].InnerText;
                    string horainicio1 = horainicio[i].InnerText;
                    string horafin1 = horafin[i].InnerText;
                    if (status1 == "0")
                        status1 = "Activo";
                    else
                        status1 = "Inactivo";
                    tablaConsulta.Rows.Add(id1, clase1, codigo1, ubicacion1, instructor1, horainicio1, horafin1, status1);


                }
                return tablaConsulta;
            
            
            
            }

            if (consultar.RBInstructor == true)
            {
                string listaConsulta = consulta.ServicioConsultarPorInstructor(consultar.TXTInstructor);
                XmlDocument consultas = new XmlDocument();
                consultas.LoadXml(listaConsulta);
                XmlNodeList classroom = consultas.GetElementsByTagName("ClasesSalon");
                XmlNodeList listaCS = ((XmlElement)classroom[0]).GetElementsByTagName("ClaseSalon");

                foreach (XmlElement nodo in listaCS)
                {
                    int i = 0;
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList clase = nodo.GetElementsByTagName("Clase");
                    XmlNodeList codigo = nodo.GetElementsByTagName("Codigo");
                    XmlNodeList ubicacion = nodo.GetElementsByTagName("Ubicacion");
                    XmlNodeList instructor = nodo.GetElementsByTagName("Instructor");
                    XmlNodeList horainicio = nodo.GetElementsByTagName("HInicio");
                    XmlNodeList horafin = nodo.GetElementsByTagName("HHFin");
                    XmlNodeList status = nodo.GetElementsByTagName("Status");

                    string id1 = id[i].InnerText;
                    string status1 = status[i].InnerText;
                    string codigo1 = codigo[i].InnerText;
                    string clase1 = clase[i].InnerText;
                    string ubicacion1 = ubicacion[i].InnerText;
                    string instructor1 = instructor[i].InnerText;
                    string horainicio1 = horainicio[i].InnerText;
                    string horafin1 = horafin[i].InnerText;
                    if (status1 == "0")
                        status1 = "Activo";
                    else
                        status1 = "Inactivo";
                    tablaConsulta.Rows.Add(id1, clase1, codigo1, ubicacion1, instructor1, horainicio1, horafin1, status1);


                }
                return tablaConsulta;
            
            
            }

          
            
            
            
            
            
            
            
            
            
            
            
            return tablaConsulta;
            
            }
        
      }
    }
