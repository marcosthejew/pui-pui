using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Comandos;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTRutina;

namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PRutina
{
    public class PresentadorModificarRutina
    {
        #region Atributos

        private IContratoBuscarRutina _vista;
        private AComando<string> _comando1;
        private AComando<DataTable> _comando2;
        
        #endregion

        #region Constructor

        public PresentadorModificarRutina(IContratoBuscarRutina vista)
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