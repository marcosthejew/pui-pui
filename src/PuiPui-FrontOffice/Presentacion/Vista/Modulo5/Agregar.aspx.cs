using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.Rutinas;
using PuiPui_FrontOffice.Entidades.Cliente; //en caso de estar en el back Office

using PuiPui_FrontOffice.Entidades.Ejercicio; //en caso de estar en el front Office




namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo5
{


    public partial class Agregar : System.Web.UI.Page
    {
        static List<String> nombre_ejercicios = new List<String>();
        static List<int> id_ejercicios = new List<int>();

        PuiPui_FrontOffice.Entidades.Cliente.Persona persona;
        PuiPui_FrontOffice.Entidades.Cliente.Acceso acceso;
        string loginPersona;
        protected void Page_Load(object sender, EventArgs e)
        {



            try
            {
                acceso = (PuiPui_FrontOffice.Entidades.Cliente.Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias

                //a partir de aquí colocan toda la lógica de sus pantallas si desean usar el (!IsPostBack) lo pueden hacer sin ningún problema

                if (!IsPostBack)
                {
                    LogicaRutina larutina = new LogicaRutina();

                    List<Ejercicio> ejercicios = larutina.ConsultaTodoEjercicios();
                    int i = 0;
                    foreach (Ejercicio ejer in ejercicios)
                    {
                        DropDownList1.DataTextField = ejer.Nombre;
                        DropDownList1.DataValueField = ejer.Id.ToString();
                        DropDownList1.Items.Insert(i, ejer.Nombre);
                        i = i++;
                    }





                    //this.DropDownList1.DataSource = larutina.ConsultaTodoEjercicios();


                    //this.DropDownList1.DataValueField = "Nombre";
                    //this.DropDownList1.DataBind();

                    /*
                    TextBox t = new TextBox();
                    t.Multiline = true;
                    t.Text = "Esto es una linea \r\n y esto es otra";
                    var primercaracter = t.GetFirstCharIndexFromLine(1);
                    t.SelectionStart = primercaracter;
                    */
                    //el código que quieran!
                }

            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {

                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }

            //String par
            //parar =  TimeSelector1.ToString();
            //System.Diagnostics.Trace.WriteLine(TimeSelector1.Hour.ToString());
            //TimeSelector1.Hour.ToString;
        }


        //hacer un  VALIDAR q no exista la rutina
        protected void Button1_Click(object sender, EventArgs e)
        {
            LogicaRutina larutina = new LogicaRutina();
            ListaEjerText.Text += "*" + DropDownList1.SelectedItem.Value + "\n";



            nombre_ejercicios.Add(DropDownList1.SelectedItem.Value);


        }


        //boton de enviar tienen q estar llenos todos los campos
        protected void Button2_Click(object sender, EventArgs e)
        {


            int hora = Convert.ToInt32(TextBoxHora.Text.ToString());
            int minuto = Convert.ToInt32(TextBoxMin.Text.ToString());
            int segundo = Convert.ToInt32(TextBoxSeg.Text.ToString());

            int repeticiones = Convert.ToInt32((TextBoxRe.Text.ToString()));



            String descri = TextBoxDescripcion.Text.ToString();



            DateTime hora_insertar = new DateTime(2013, 11, 12, hora, minuto, segundo);


            LogicaRutina RutiAinsert = new LogicaRutina();

            RutiAinsert.InsertaRutina(descri, hora_insertar, repeticiones);



            //int cliente_id;
            int ultima_rutina_id;
            Ejercicio ejer_id = new Ejercicio();
            Persona per_id = new Persona();


            for (int j = 0; j < nombre_ejercicios.Count; j++)
            {
                ejer_id = RutiAinsert.BuscaDatos_Ejercicio(nombre_ejercicios[j]);

                id_ejercicios.Add(ejer_id.Id);
                ListaEjerText.Text += id_ejercicios[j] + "\n";
            }
            


            ultima_rutina_id = RutiAinsert.Devuelve_Ultimo_ID();
            ListaEjerText.Text += "\n" + loginPersona;
            per_id = RutiAinsert.BuscaIDNombrePersona(loginPersona);


            
            ListaEjerText.Text += "\n" + per_id.IdPersona;
            ListaEjerText.Text += "\n" + ultima_rutina_id;


            bool inserto;
            inserto = RutiAinsert.Inserta_Historial(per_id.IdPersona, ultima_rutina_id, 3);




            for (int j = 0; j < nombre_ejercicios.Count; j++)
            {
                inserto = RutiAinsert.Inserta_Historial(per_id.IdPersona, ultima_rutina_id, id_ejercicios[j]);
            }

        }



    }
}