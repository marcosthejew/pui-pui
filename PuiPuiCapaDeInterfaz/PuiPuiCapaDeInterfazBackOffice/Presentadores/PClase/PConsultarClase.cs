using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;
using PuiPuiCapaDeInterfazBackOffice.LogicaClase;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// Vista de Consultar clase con la capa de Logica de negocios.
    /// </summary>
    public class PConsultarClase
    {
        IContratoConsultarClase consultar;

        public PConsultarClase(IContratoConsultarClase vista_consultar){
           this.consultar = vista_consultar;
        
        }
        /// <summary>
        /// Consulta las clases de gym que capa de datos pasando por la logica
        /// ya sea todas las clases o las clases por datos especificos
        /// </summary>
        /// <returns>DataTable</returns>

        public DataTable ConsultaClase() {

            FachadaClasesSoapClient consulta= new FachadaClasesSoapClient();
            DataTable tablaConsulta = new DataTable();
            tablaConsulta.Columns.Add("ID_Clase", typeof(string));
            tablaConsulta.Columns.Add("Clase", typeof(string));
            tablaConsulta.Columns.Add("Descripcion", typeof(string));
            tablaConsulta.Columns.Add("Status", typeof(string));

            if (consultar.RBConsultaCompleta == true)
            {
                string lista_clase = consulta.ServicioConsultarSalonesTodos();
                XmlDocument clases = new XmlDocument();
                clases.LoadXml(lista_clase);
                XmlNodeList classroom = clases.GetElementsByTagName("Clases");
                XmlNodeList listaClase = ((XmlElement)classroom[0]).GetElementsByTagName("ClaseSalon");

                foreach (XmlElement nodo in listaClase)
                {
                    int i = 0;
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList status = nodo.GetElementsByTagName("Status");
                    XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                    XmlNodeList clase = nodo.GetElementsByTagName("Nombre");
                    string id1 = id[i].InnerText;
                    string status1 = status[i].InnerText;
                    string descripcion1 = descripcion[i].InnerText;
                    string clase1 = clase[i].InnerText;
                    if (status1 == "0")
                        status1 = "Activo";
                    else
                        status1 = "Inactivo";
                    tablaConsulta.Rows.Add(id1, clase1, descripcion1, status1);



                }
                return tablaConsulta;
            }

            if (consultar.RBconsultaClasePorNombres == true)
            {
                string lista_clase = consulta.ServicioComandoNombreClase(consultar.TextNombreClase);
                if (lista_clase != null)
                {
                    XmlDocument clases = new XmlDocument();
                    clases.LoadXml(lista_clase);
                    XmlNodeList classroom = clases.GetElementsByTagName("Clases");
                    XmlNodeList listaClase = ((XmlElement)classroom[0]).GetElementsByTagName("Clase");

                    foreach (XmlElement nodo in listaClase)
                    {
                        int i = 0;
                        XmlNodeList id = nodo.GetElementsByTagName("Id");
                        XmlNodeList status = nodo.GetElementsByTagName("Status");
                        XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                        XmlNodeList clase = nodo.GetElementsByTagName("Nombre");
                        string id1 = id[i].InnerText;
                        string status1 = status[i].InnerText;
                        string descripcion1 = descripcion[i].InnerText;
                        string clase1 = clase[i].InnerText;
                        if (status1 == "0")
                            status1 = "Activo";
                        else
                            status1 = "Inactivo";
                        tablaConsulta.Rows.Add(id1, clase1, descripcion1, status1);



                    }
                    return tablaConsulta;


                }
            
            }
            if (consultar.RBPorStatus == true)
            {

                if (consultar.DPLStatus.Trim() == "0")
                {

                    string lista_clase = consulta.ServicioComandoBusquedaStatusClases(0);
                    XmlDocument clases = new XmlDocument();
                    clases.LoadXml(lista_clase);
                    XmlNodeList classroom = clases.GetElementsByTagName("Clases");
                    XmlNodeList listaClase = ((XmlElement)classroom[0]).GetElementsByTagName("Clase");

                    foreach (XmlElement nodo in listaClase)
                    {
                        int i = 0;
                        XmlNodeList id = nodo.GetElementsByTagName("Id");
                        XmlNodeList status = nodo.GetElementsByTagName("Status");
                        XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                        XmlNodeList clase = nodo.GetElementsByTagName("Nombre");
                        string id1 = id[i].InnerText;
                        string status1 = status[i].InnerText;
                        string descripcion1 = descripcion[i].InnerText;
                        string clase1 = clase[i].InnerText;
                        if (status1 == "0")
                            status1 = "Activo";
                        else
                            status1 = "Inactivo";
                        tablaConsulta.Rows.Add(id1, clase1, descripcion1, status1);



                    }
                    return tablaConsulta;


                }
                else
                {

                    string lista_clase = consulta.ServicioComandoBusquedaStatusClases(1);
                    XmlDocument clases = new XmlDocument();
                    clases.LoadXml(lista_clase);
                    XmlNodeList classroom = clases.GetElementsByTagName("Clases");
                    XmlNodeList listaClase = ((XmlElement)classroom[0]).GetElementsByTagName("Clase");

                    foreach (XmlElement nodo in listaClase)
                    {
                        int i = 0;
                        XmlNodeList id = nodo.GetElementsByTagName("Id");
                        XmlNodeList status = nodo.GetElementsByTagName("Status");
                        XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                        XmlNodeList clase = nodo.GetElementsByTagName("Nombre");
                        string id1 = id[i].InnerText;
                        string status1 = status[i].InnerText;
                        string descripcion1 = descripcion[i].InnerText;
                        string clase1 = clase[i].InnerText;
                        if (status1 == "0")
                            status1 = "Activo";
                        else
                            status1 = "Inactivo";
                        tablaConsulta.Rows.Add(id1, clase1, descripcion1, status1);



                    }
                    return tablaConsulta;


                
                
                }
            
            }
            return tablaConsulta;
        }

    }
}