using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTRutina;
using PuiPuiCapaDeInterfazFrontOffice.Comandos;
using System.Web.UI.WebControls;
using System.Data;

namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PRutina
{
    public class PresentadorActivarInactivarRutina
    {
        #region Atributos

        private IContratoActivarInactivarRutina _vista;
        private AComando<string> _comando1;
        private AComando<DataTable> _comando2;
        private AComando<bool> _comando3;

        #endregion

        #region Constructor

        public PresentadorActivarInactivarRutina(IContratoActivarInactivarRutina vista)
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

        public void ActivarInactivarRutina(int idRutina, byte Inactivo)
        {
            _comando3 = FabricaComando.CrearComandoActivarInactivarRutina(idRutina, Inactivo);
            bool resultado = false;
            resultado = _comando3.Ejecutar();

            if (resultado == Convert.ToBoolean(1))
                Inactivo = Convert.ToByte(0);
            else
                Inactivo = Convert.ToByte(1);

            new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().ActivarInactivarRutina(idRutina, Inactivo);
        }
        #endregion


        public void StatusRutinaDeRutina(int idRutina)
        {
            
            
            byte Inactivo = 0;
            _comando1 = FabricaComando.CrearComandoStatusDeRutina(idRutina);
            string resultadoComando = "";
            resultadoComando = _comando1.Ejecutar();

            string resultadoComando2;
            _comando1 = FabricaComando.CrearComandoDesSerializarStatus(resultadoComando);
            resultadoComando2 = _comando1.Ejecutar();



            if (resultadoComando2 == "false")
                Inactivo = Convert.ToByte(0) ;
            else if (resultadoComando2 == "true")
                Inactivo = Convert.ToByte(1);

            ActivarInactivarRutina(idRutina, Inactivo);

        }
    }
}