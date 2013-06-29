using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTRutina;
using PuiPuiCapaDeInterfazFrontOffice.Presentadores.PRutina;

namespace PuiPuiCapaDeInterfazFrontOffice.Vistas
{
    public partial class ActivarInactivarRutina : System.Web.UI.Page, IContratoActivarInactivarRutina
    {
        #region Atributos

        private PresentadorActivarInactivarRutina _presentador;

        #endregion

        #region Constructor

        public ActivarInactivarRutina()
        {
            _presentador = new PresentadorActivarInactivarRutina(this);
        }

        #endregion

        #region Contrato

        public GridView GridConsultar1
        {
            get { return GridConsultar; }
            set { GridConsultar = value; }
        }

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
                int _idCliente;
                _idCliente = 7;
                _presentador.PintarConsultaRutina(_idCliente);

        }
        protected void GridConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRutina = GridConsultar.SelectedIndex;
            _presentador.StatusRutinaDeRutina(idRutina);

            Response.Redirect("ActivarInactivarRutina.aspx");
            
        }

        protected void GridConsultar_RowCommand(Object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridConsultar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
        public void Redireccionar(string _ruta)
        {
            Response.Redirect(_ruta);
        }



        #endregion

    }
}