using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos;
using PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PDesactivarMusculo
    {
        #region atributos
        private IContratoDesactivarMusculo _vistaDesrMusculo;
        #endregion

        #region Constructor
        public PDesactivarMusculo(IContratoDesactivarMusculo vistaDesactivarMusculo)
        {
            _vistaDesrMusculo = vistaDesactivarMusculo;
        }
        #endregion

        #region metodos
        public void CargarMusculos()
        {
            FabricaComando.CrearComandoCargarMusculos(_vistaDesrMusculo);
        }

        public void DesactivarMusculo(int num, string nombre)
        {
            //Cambiar el envio
            if (FabricaComando.CrearComandoDesactivarMusculo(num).Ejecutar())
            {
                _vistaDesrMusculo.Exito = "Ingreso Exitoso";
                (_vistaDesrMusculo as VistaDesactivarMusculo).Mensaje.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                _vistaDesrMusculo.Exito = "Falla al Agregar";
                (_vistaDesrMusculo as VistaDesactivarMusculo).Mensaje.ForeColor = System.Drawing.Color.Red;
            }

            (_vistaDesrMusculo as VistaDesactivarMusculo).Mensaje.Visible = true;
        }
        #endregion

    }
}