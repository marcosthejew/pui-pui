using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor
{
    public partial class AgregarClaseSalon : System.Web.UI.Page
    {
        List<Clase> _listClase = new List<Clase>();
        List<Salon> _listSalon = new List<Salon>();
        List<Instructor> _listInstructor = new List<Instructor>();
        List<ClaseSalon> _listClaseSalon = new List<ClaseSalon>();
        LogicaClase _accesoClase = new LogicaClase();
        LogicaSalon _accesosSalon = new LogicaSalon();
        LogicaInstructor _accesoInstructor = new LogicaInstructor();

        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCombos();

        }
        private void Init()
        {
            _listClase = new List<Clase>();
            _listSalon = new List<Salon>();
            _listInstructor = new List<Instructor>();
            _listClaseSalon = new List<ClaseSalon>();
            _accesoClase = new LogicaClase();
            _accesosSalon = new LogicaSalon();
            _accesoInstructor = new LogicaInstructor();
        }
        private void LlenarCombos()
        {
            _listClase = _accesoClase.ObtenerClases();
            _listSalon = _accesosSalon.ObtenerSalones();
            _listInstructor = _accesoInstructor.ConsultarTodosInstructores();

            foreach (Clase clas in _listClase)
            {
                ComboClase.Items.Add(clas.Nombre);
            }
            foreach (Salon sal in _listSalon)
            {
                ComboSalon.Items.Add(sal.Ubicacion);
            }
            foreach (Instructor ins in _listInstructor)
            {
                ComboInstructor.Items.Add(ins.NombrePersona1+" "+ins.ApellidoPersona1);
            }

        }
        protected void defaultButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int idc, ids, idi;

                    flag = _accesosSalon.AgregarSalonesClase(_listClase[ComboClase.SelectedIndex].IdClase, _listInstructor[ComboInstructor.SelectedIndex].IdPersona, _listSalon[ComboSalon.SelectedIndex].IdSalon);
                    if (flag == true)
                    {
                        Exito.Visible = true;
                    }
                    else
                    {
                        falla.Visible = true;
                    }

              


        }
        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Home/Home.aspx");
        }
    }
}
