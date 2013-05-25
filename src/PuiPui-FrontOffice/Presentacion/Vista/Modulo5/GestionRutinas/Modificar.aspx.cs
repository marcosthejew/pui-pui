using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.Rutinas;
using PuiPui_FrontOffice.Entidades.Rutina;
using PuiPui_FrontOffice.Entidades.Ejercicio;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.LogicaDeNegocios.Exepciones;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo5.GestionRutinas
{
    public partial class Modificar : System.Web.UI.Page
    {
        #region Atributos
        PuiPui_FrontOffice.Entidades.Cliente.Acceso acceso;
        string loginPersona;
        LogicaRutina rutinas_modificar = new LogicaRutina();
        Rutina rutinas = new Rutina();
        Historial_Ejercicio historia_modificar = new Historial_Ejercicio();
        List<Rutina> lista_rutinas = new List<Rutina>();
        List<Historial_Ejercicio> lista_id_rutinas = new List<Historial_Ejercicio>();
        List<Historial_Ejercicio> lista_id_ejercicios = new List<Historial_Ejercicio>();
        Ejercicio ejercicios = new Ejercicio();
        List<Ejercicio> lista_ejercicio = new List<Ejercicio>();
        Persona per_id = new Persona();
        static List<String> nombre_ejercicios = new List<String>();
       static Rutina mod_rutina = new Rutina();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                acceso = (PuiPui_FrontOffice.Entidades.Cliente.Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;
                if (!IsPostBack)
                {
                    per_id = rutinas_modificar.BuscaIDNombrePersona(loginPersona);
                    lista_id_rutinas = rutinas_modificar.Lista_Rutinas_Historial(per_id.IdPersona);

                    for (int j = 0; j < lista_id_rutinas.Count; j++)
                    {
                        rutinas = rutinas_modificar.ConsultaRutina(lista_id_rutinas[j].Id_rutina);

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

        public static void ShowAlertMessage(string message)
        {
            Page page = HttpContext.Current.Handler as Page;
            if (page != null)
            {
                message = message.Replace("'", "\'");
                System.Web.UI.ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + message + "');", true);
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
                per_id = rutinas_modificar.BuscaIDNombrePersona(loginPersona);
                string index = ddlRutinas.SelectedValue.Trim();
               
                lista_rutinas = rutinas_modificar.TodasRutinas();
                int i = 0;
                foreach (Rutina ruti in lista_rutinas)
                {


                    if (index == lista_rutinas[i].Descripcion.Trim())
                    {
                        mod_rutina = new Rutina(lista_rutinas[i].Id_rutina, lista_rutinas[i].Descripcion, lista_rutinas[i].Tiempo, lista_rutinas[i].Repeteciones);

                    }
                    i++;

                }

                lista_id_ejercicios = rutinas_modificar.Lista_Ejercicios_Historial(per_id.IdPersona, mod_rutina.Id_rutina);
                for (int k = 0; k < lista_id_ejercicios.Count; k++)
                {
                    ejercicios = rutinas_modificar.ListaEjercicios_Rutina(lista_id_ejercicios[k].Id_ejercicio);
                    lista_ejercicio.Add(ejercicios);
                    tbDescripcion0.Text += "*" + ejercicios.Nombre;
                    tbNombre0.Text = mod_rutina.Descripcion;
                    tbNombre0.Enabled = false;
                    LRepeticiones.Text = mod_rutina.Repeteciones.ToString();
                    LTiempo.Text = mod_rutina.Tiempo.ToString("HH:mm:ss");
                }

                List<Ejercicio> l_ejercicios = rutinas_modificar.ConsultaTodoEjercicios();
                int w = 0;
                foreach (Ejercicio ejer in l_ejercicios)
                {
                    DDLTEjercicios.DataTextField = ejer.Nombre;
                    DDLTEjercicios.DataValueField = ejer.Id.ToString();
                    DDLTEjercicios.Items.Insert(w, ejer.Nombre);
                    w = w++;
                }


            }
        }

        protected void DDLTEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbDescripcion1.Text += "*" + DDLTEjercicios.SelectedItem.Value + "\n";



            nombre_ejercicios.Add(DDLTEjercicios.SelectedItem.Value);
        }

        protected void bModificar_Click(object sender, EventArgs e)
        {

            int repeticiones;
            int minuto;
            int hora;
            int segundo;
            
            


            if (TextBoxHora.Text == "" || TextBoxMin.Text == "" || TextBoxSeg.Text == "" || tbNombreNuevo.Text == "")
            {
                //textboxVacios = true;

                ShowAlertMessage("Hay campos vacios");

                //Response.Write("<script>alert('Hay campos vacios');</script>");

            }

            else
            {
                if (TextBoxRe.Text == "")
                    repeticiones = 0;
                else
                    repeticiones = Convert.ToInt32(TextBoxRe.Text.ToString());

              
               hora = Convert.ToInt32(TextBoxHora.Text.ToString());
               minuto = Convert.ToInt32(TextBoxMin.Text.ToString());
               segundo = Convert.ToInt32(TextBoxSeg.Text.ToString());

               if (minuto <= 0 || minuto >= 59 || segundo <= 0 || segundo >= 59 || hora <= 0 || hora >= 24)
               {
                   //validarTiempo = true;
                   ShowAlertMessage("El formato correcto del tiempo es hora/minuto/segundo");
               }
               else
               {


                   String descri = tbNombreNuevo.Text.ToString();
                   DateTime hora_insertar = new DateTime(2013, 11, 12, hora, minuto, segundo);


                   Rutina upd_rutina = new Rutina(mod_rutina.Id_rutina, descri, hora_insertar, repeticiones);
                   bool actualizo = rutinas_modificar.Update_Rutina(upd_rutina);

                   if (actualizo == true)
                   {


                       lista_id_ejercicios = rutinas_modificar.Lista_Ejercicios_Historial(per_id.IdPersona, mod_rutina.Id_rutina);
                       lExito.Text = "Se ha modificado exitosamente.";
                       lExito.ForeColor = System.Drawing.Color.Blue;
                       lExito.Visible = true;


                   }
                   else
                   {
                       lExito.Text = "El nombre de la rutina ya se encuentra asociado a otro Rutina.";
                       lExito.ForeColor = System.Drawing.Color.Red;
                       lExito.Visible = true;

                   }
               }


                
                }




            Response.Redirect("/Presentacion/Vista/Modulo5/Modificar.aspx");
            }  
      }
    }
