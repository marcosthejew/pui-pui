﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.Rutinas;
using PuiPui_FrontOffice.Entidades.Rutina;
using PuiPui_FrontOffice.Entidades.Cliente; //en caso de estar en el back Office

using PuiPui_FrontOffice.Entidades.Ejercicio;
using PuiPui_FrontOffice.LogicaDeNegocios.Exepciones; //en caso de estar en el front Office



namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo5
{
    public partial class Consultar : System.Web.UI.Page
    {

        static List<String> nombre_ejercicios = new List<String>();
        static List<int> id_ejercicios = new List<int>();

        PuiPui_FrontOffice.Entidades.Cliente.Acceso acceso;
        string loginPersona;
        LogicaRutina RutiAinsert = new LogicaRutina();
        Persona per_id = new Persona();
        Rutina rutinas = new Rutina();
        List<Rutina> lista_rutinas = new List<Rutina>();



        List<Historial_Ejercicio> lista_id_rutinas = new List<Historial_Ejercicio>();
        List<Historial_Ejercicio> lista_id_ejercicios = new List<Historial_Ejercicio>();
        Ejercicio ejercicios = new Ejercicio();
        List<Ejercicio> lista_ejercicio = new List<Ejercicio>();


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                acceso = (PuiPui_FrontOffice.Entidades.Cliente.Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;
                if (!IsPostBack)
                {
                    per_id = RutiAinsert.BuscaIDNombrePersona(loginPersona);
                    lista_id_rutinas = RutiAinsert.Lista_Rutinas_Historial(per_id.IdPersona);

                    for (int j = 0; j < lista_id_rutinas.Count; j++)
                    {
                        rutinas = RutiAinsert.ConsultaRutina(lista_id_rutinas[j].Id_rutina);

                        lista_rutinas.Add(rutinas);


                    }
                    Cargar_Rutinas(lista_rutinas);

                }
            }
            catch (NullReferenceException)
            {

                Response.Redirect("../../Home/Login.aspx");
            }
        }


        protected void Cargar_Rutinas(List<Rutina> lista_rutinas)
        {

            ddlRutinas.Items.Clear();

            try
            {
                ddlRutinas.Items.Insert(0, new ListItem("Seleccione", "0"));
                if (lista_rutinas != null)
                {

                    int i = 1;
                    foreach (Rutina rut in lista_rutinas)
                    {
                        ddlRutinas.DataTextField = rut.Descripcion;
                        ddlRutinas.DataValueField = rut.Id_rutina.ToString();
                        ddlRutinas.Items.Insert(i, rut.Descripcion);
                        i++;
                    }
                }
                else
                {
                    ddlRutinas.Enabled = false;
                    lExito.Visible = true;
                }
            }
            catch (ExcepcionRutina error)
            {
                lExito.Text = error.Message;
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
            }

        }


        protected void ddlRutinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRutinas.SelectedIndex > 0)
            {
                acceso = (PuiPui_FrontOffice.Entidades.Cliente.Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;
                per_id = RutiAinsert.BuscaIDNombrePersona(loginPersona);
                string index = ddlRutinas.SelectedValue.Trim();
                Rutina elimina_rutina = new Rutina();
                lista_rutinas = RutiAinsert.TodasRutinas();
                int i = 0;
                foreach (Rutina ruti in lista_rutinas)
                {


                    if (index == lista_rutinas[i].Descripcion.Trim())
                    {
                        elimina_rutina = new Rutina(lista_rutinas[i].Id_rutina, lista_rutinas[i].Descripcion, lista_rutinas[i].Tiempo, lista_rutinas[i].Repeteciones);

                    }
                    i++;

                }

                lista_id_ejercicios = RutiAinsert.Lista_Ejercicios_Historial(per_id.IdPersona, elimina_rutina.Id_rutina);
                for (int k = 0; k < lista_id_ejercicios.Count; k++)
                {
                    ejercicios = RutiAinsert.ListaEjercicios_Rutina(lista_id_ejercicios[k].Id_ejercicio);
                    lista_ejercicio.Add(ejercicios);
                    tbDescripcion.Text += "*" + ejercicios.Nombre;
                    tbNombre.Text = elimina_rutina.Descripcion;
                    tbRepeticiones.Text = elimina_rutina.Repeteciones.ToString();
                    tbTiempo.Text = elimina_rutina.Tiempo.ToString("HH:mm:ss");
                }



            }
        }




    }
}



