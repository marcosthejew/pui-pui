using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoDesSerializarRutina : AComando<DataTable>
    {
        string rutina;

        public ComandoDesSerializarRutina(string _rutina)
        {
            this.rutina = _rutina;
        }
        public override DataTable Ejecutar()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("idRutina", typeof(string));
                table.Columns.Add("nombre", typeof(string));
                table.Columns.Add("descripcion", typeof(string));
                table.Columns.Add("status", typeof(string));    

                XmlDocument xml = new XmlDocument();
                xml.Load(new System.IO.StringReader(rutina));
                XmlNodeList rutinas = xml.GetElementsByTagName("Rutinas");
                XmlNodeList xnList = ((XmlElement)rutinas[0]).GetElementsByTagName("Rutina");
                int l = 0;
                foreach (XmlElement nodo in xnList)
                {
                    XmlNodeList id = nodo.GetElementsByTagName("Id");
                    XmlNodeList nombre = nodo.GetElementsByTagName("Nombre");
                    XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                    XmlNodeList status = nodo.GetElementsByTagName("Status");

                    string id1 = id[l].InnerText;
                    string nombre1 = nombre[l].InnerText;
                    string descripcion1 = descripcion[l].InnerText;
                    string status1 = status[l].InnerText;

                    

                    table.Rows.Add(id1,nombre1,descripcion1,status1);
                    
                }
                
                // return new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().ConsultarRutinasPorIDCliente(rutina);
                

                return table;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}