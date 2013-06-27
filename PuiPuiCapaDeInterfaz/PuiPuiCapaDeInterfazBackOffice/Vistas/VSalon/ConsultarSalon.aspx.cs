using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon;
using System.Data;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon
{
    public partial class ConsultarSalon : System.Web.UI.Page, IContratoConsultaSalon
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      public  Boolean RBConsultaCompleta {

          get { return consultaCompleta.Checked; }
          set { RBConsultaCompleta = value; }
      }

      public Boolean RBUbicacion {
          get { return consultarSalonPorUbicacion.Checked;}
          set { RBUbicacion = value; }
      }

      public Boolean RBCapacidad {
          get { return consultarSalonPorCapacidad.Checked; }
          set { RBCapacidad = value; }
      
      }
        public Boolean RBStatus {

            get { return consultaSalonPorStatus.Checked; }
            set { RBStatus = value; }
    }
        public String TextNombreSalon {
            get { return salon.Text; }
            set { salon.Text = value; }
        
        }
        public String DPLStatus {
            get { return DropDownListStatusSalon.SelectedValue; }
            set { DPLStatus = value; }
        
        }
        public String DPLCapacidad {

            get { return DropDownListCapacidadSalon.SelectedValue; }
            set { DPLCapacidad = value; }
        
        }
        public int TxtCapacidad {
            get { return int.Parse(TextBoxCapacidad.Text); }
            set { TxtCapacidad = value; }
        
        }
        protected void botonBuscarSalon_Click(object sender, EventArgs e)
        {
          /*  if ((consultarSalonPorCapacidad.Checked == false) || (consultaCompleta.Checked == false) || (consultarSalonPorUbicacion.Checked == false) || (consultaSalonPorStatus.Checked = false) || (salon.Text.Equals("")) || (TextBoxCapacidad.Text.Equals("")))
            {



            }
            else */
                PConsultarSalon consultar = new PConsultarSalon(this);
                GridConsultar.DataSource= consultar.Consultar_salones();
                GridConsultar.DataBind();
               
            
            
            
            
            
        }
    }
}