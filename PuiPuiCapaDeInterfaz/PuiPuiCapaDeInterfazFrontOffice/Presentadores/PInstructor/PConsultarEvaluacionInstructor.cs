using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor;
using PuiPuiCapaDeInterfazFrontOffice.FachadaInstructoresFrontOffice;

namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PInstructor
{
    public class PConsultarEvaluacionInstructor
    {
        IContratoConsultarEvaluacionInstructor consultar;

        public PConsultarEvaluacionInstructor(IContratoConsultarEvaluacionInstructor vista_consultar)
        {
           this.consultar = vista_consultar;
        
        }

        public DataTable ConsultaClase() {

            FachadaInstructoresSoapClient consulta = new FachadaInstructoresSoapClient();


            if (consultar.RBConsultaCompleta ==true)
            {
                string lista_evalucion = consulta.ServicioComandoConsultarEvaluacionesInstructorTodos();
                return construirtabla(lista_evalucion,"");
            }
            else if (consultar.RBconsultaInstructorPorNombres == true)
            {
                string lista_evalucion = consulta.ServicioComandoConsultarEvaluacionesInstructorTodos();
                return construirtabla(lista_evalucion, consultar.TextNombreInstrutor);
            }

            return null;
        }


        private DataTable construirtabla(String listaevaluacion,String filtro)
        {
            DataTable tablaConsulta = new DataTable();
            tablaConsulta.Columns.Add("ID", typeof(string));
            tablaConsulta.Columns.Add("Fecha", typeof(string));
            tablaConsulta.Columns.Add("Observaciones", typeof(string));
            tablaConsulta.Columns.Add("Cliente", typeof(string));
            tablaConsulta.Columns.Add("Instructor", typeof(string));
            tablaConsulta.Columns.Add("Calificacion", typeof(string));
            XmlDocument clases = new XmlDocument();
            clases.LoadXml(listaevaluacion);
            XmlNodeList classroom = clases.GetElementsByTagName("EvaluacionInst");
            XmlNodeList listaClase = ((XmlElement)classroom[0]).GetElementsByTagName("EvalucionInstructor");

            foreach (XmlElement nodo in listaClase)
            {
                int i = 0;
                XmlNodeList id = nodo.GetElementsByTagName("Id");
                XmlNodeList Fecha = nodo.GetElementsByTagName("Fecha");
                XmlNodeList Observaciones = nodo.GetElementsByTagName("Observaciones");
                XmlNodeList Cliente = nodo.GetElementsByTagName("Cliente");
                XmlNodeList Instructor = nodo.GetElementsByTagName("Instructor");
                XmlNodeList Calificacion = nodo.GetElementsByTagName("Calificacion");
                string id1 = id[i].InnerText;
                string fecha1 = Fecha[i].InnerText;
                string observaciones1 = Observaciones[i].InnerText;
                string clase1 = Cliente[i].InnerText;
                string instructor1 = Instructor[i].InnerText;
                string calificacion1 = Calificacion[i].InnerText;
                if (filtro=="")
                    tablaConsulta.Rows.Add(id1, fecha1, observaciones1, clase1, instructor1, calificacion1);
                 else if (instructor1.Equals(filtro))
                    tablaConsulta.Rows.Add(id1, fecha1, observaciones1, clase1, instructor1, calificacion1);
            }
            return tablaConsulta;
        }
    }
}