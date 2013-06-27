using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.FrontOffice
{
    public class FachadaRutinasEjercicios : System.Web.Services.WebService
    {
        string resultado = "";
        [WebMethod]
        public string ObtenerRutinas(string login)
        {
            string respuesta;
            respuesta = "Respuesta Cableada";
            return respuesta;
        }
        [WebMethod]
        public string ConsultarRutinasPorIDCliente(int idCliente)
        {
            List<Rutina> listaRutina = new List<Rutina>();
            Rutina entidadRutina = new Rutina();
            Ejercicio entidadEjercicio = new Ejercicio();
            listaRutina = Fabricas.FabricaComando.CrearComandoConsultarRutinasPorIDCliente().Ejecutar();
            resultado = "<Rutinas>";

            foreach (Rutina rutina in listaRutina)
            {
                string objeto = entidadRutina.SerializarRutinas(rutina);

                resultado += objeto;
                objeto = " ";
            }
            resultado = resultado + "</Rutinas>";
            XmlDocument xml = new XmlDocument();
            xml.Load(new System.IO.StringReader(resultado));
            XmlNodeList xnList = xml.SelectNodes("Rutina");
            int l = 0;
            foreach (XmlElement nodo in xnList)
            {
                XmlNodeList id = nodo.GetElementsByTagName("Id");
                XmlNodeList nombre = nodo.GetElementsByTagName("Nombre");
                XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                resultado = id[l].InnerText;
                resultado = nombre[l].InnerText;
                resultado = descripcion[l].InnerText;
                l++;

            }

            return resultado;
        }

        [WebMethod]
        public string ComandoConsultarEjerciciosPorIDRutina(int idRutina)
        {
            List<Ejercicio> listaEjercicio = new List<Ejercicio>();
            Rutina entidadEjercicio = new Rutina();

            listaEjercicio = Fabricas.FabricaComando.CrearComandoConsultarEjerciciosPorIDRutina().Ejecutar();
            string resultado = "<Ejercicios>";

            foreach (Ejercicio ejercicio in listaEjercicio)
            {
                string objeto = entidadEjercicio.SerializarEjercicio(ejercicio);

                resultado += objeto;
                objeto = " ";
            }
            resultado = resultado + "</Ejercicios>";
            XmlDocument xml = new XmlDocument();
            xml.Load(new System.IO.StringReader(resultado));
            XmlNodeList xnList = xml.SelectNodes("Ejercicio");

            int h = 0;

            foreach (XmlElement nodo in xnList)
            {
                XmlNodeList id = nodo.GetElementsByTagName("Id");
                XmlNodeList nombre = nodo.GetElementsByTagName("Nombre");
                XmlNodeList descripcion = nodo.GetElementsByTagName("Descripcion");
                XmlNodeList duracion = nodo.GetElementsByTagName("Duracion");
                XmlNodeList repeticiones = nodo.GetElementsByTagName("Repeticiones");
                resultado = id[h].InnerText;
                resultado = nombre[h].InnerText;
                resultado = descripcion[h].InnerText;
                resultado = duracion[h].InnerText;
                resultado = repeticiones[h].InnerText;

            }

            return resultado;
        }


        [WebMethod]
        public bool ActivarInactivarRutina(int idRutina, byte inactivo)
        {
            bool entidadRutina = false;
            entidadRutina = Fabricas.FabricaComando.CrearComandoActivarInactivarRutina().Ejecutar();
            return entidadRutina;
        }

    }
}
