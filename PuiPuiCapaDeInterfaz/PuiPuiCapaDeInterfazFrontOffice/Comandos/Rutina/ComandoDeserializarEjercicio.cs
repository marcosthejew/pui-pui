using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoDeserializarEjercicio : AComando<DataTable>
    {
        string ejercicio;

        public ComandoDeserializarEjercicio(string _ejercicio)
        {
            this.ejercicio = _ejercicio;  
        }


        public override DataTable Ejecutar()
        {
            try
            {
                DataTable tablaConsulta = new DataTable();
                tablaConsulta.Columns.Add("ID_ClaseSalon", typeof(string));

                DataTable tabla = new DataTable();
                tabla.Columns.Add("Id", typeof(int));
                tabla.Columns.Add("Nombre",  typeof(string));
                tabla.Columns.Add("Descripcion", typeof(string));
                tabla.Columns.Add("Duracion", typeof(string));
                tabla.Columns.Add("Repeticiones", typeof(string));

                XmlDocument xml = new XmlDocument();
                xml.Load(new System.IO.StringReader(ejercicio));
                XmlNodeList xnList = xml.SelectNodes("Ejercicios");
                XmlNodeList xnNodo = ((XmlElement)xnList[0]).GetElementsByTagName("Ejercicio");
                int h = 0;

                foreach (XmlElement nodo in xnList)
                {
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList nombre = nodo.GetElementsByTagName("Nombre");
                    XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                    XmlNodeList duracion = nodo.GetElementsByTagName("Duracion");
                    XmlNodeList repeticiones = nodo.GetElementsByTagName("Repeticiones");
                    
                    string id1 = id[h].InnerText;
                    string nombre1 = nombre[h].InnerText;
                    string descripcion1 = descripcion[h].InnerText;
                    string duracion1 = duracion[h].InnerText;
                    string repeticiones1 = repeticiones[h].InnerText;

                    tabla.Rows.Add(id1, nombre1, descripcion1, duracion1, repeticiones1);

                }

                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}