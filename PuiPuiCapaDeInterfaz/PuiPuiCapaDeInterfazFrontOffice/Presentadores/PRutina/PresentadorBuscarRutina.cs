using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTRutina;
using PuiPuiCapaDeInterfazFrontOffice.Comandos;
using System.Web.UI.WebControls;
using System.Data;


namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PRutina
{
    public class PresentadorBuscarRutina
    {
        #region Atributos

        private IContratoBuscarRutina _vista;
        private AComando<string> _comando1;
        private AComando<DataTable> _comando2;
        
        #endregion

        #region Constructor

        public PresentadorBuscarRutina(IContratoBuscarRutina vista)
        {
            this._vista = vista;
        }

        #endregion

        #region Métodos

        public void PintarConsultaRutina(int _idCliente)
        {
            _comando1 = FabricaComando.CrearComandoConsultarRutina(_idCliente);
            string resultadoComando = "";
            resultadoComando = _comando1.Ejecutar();

            DataTable _tabla = new DataTable();
            _comando2 = FabricaComando.CrearComandoDesSerializarRutina(resultadoComando);
            _tabla = _comando2.Ejecutar();

            _vista.GridConsultar1.DataSource = _tabla;
            _vista.GridConsultar1.DataBind();

        }
        #endregion 

    }
}