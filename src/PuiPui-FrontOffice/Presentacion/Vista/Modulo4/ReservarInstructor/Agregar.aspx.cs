using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.ReservaInstructor;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo4.ReservarInstructor
{
    public partial class Agregar : System.Web.UI.Page
    {
        LogicaReservaInstructor _reserva = new LogicaReservaInstructor();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                exito.Visible = false;
                falla.Visible = false;
                cargarInstructores();
                for (int i = 0; i <= 23; i++)
                {
                    ddlHoraInicial.Items.Add(i.ToString());
                    ddlHoraFinal.Items.Add(i.ToString());
                }
                for (int i = 0; i <= 3; i++)
                {
                    ddlMinutosInicial.Items.Add((i*15).ToString());
                    ddlMinutosFinal.Items.Add((i*15).ToString());
                }
            }

        }

        protected void cargarInstructores()
        {
            Instructores.Items.Add("Seleccione un Instructor");
            Instructores.Items.Add("Instructor1 Prueba");
            Instructores.Items.Add("Instructor2 Prueba");
            Instructores.Items.Add("Instructor2 Prueba");
            Instructores.DataBind();

        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            LogicaReservaInstructor logicaReservaInstructor = new LogicaReservaInstructor();
            try
            {
                logicaReservaInstructor.agregarReservaInstructor("login",1,
                                                                 new DateTime(Calendar.SelectedDate.Year,Calendar.SelectedDate.Month,Calendar.SelectedDate.Day,
                                                                              ddlHoraInicial.SelectedIndex,ddlMinutosInicial.SelectedIndex,0),
                                                                 new DateTime(Calendar.SelectedDate.Year, Calendar.SelectedDate.Month, Calendar.SelectedDate.Day,
                                                                              ddlHoraFinal.SelectedIndex, ddlMinutosFinal.SelectedIndex, 0));
            }
            catch
            {
            }
        }
    }
}