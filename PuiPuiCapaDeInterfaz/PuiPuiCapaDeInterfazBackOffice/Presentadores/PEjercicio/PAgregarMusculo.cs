using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos;
using PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PAgregarMusculo
    {
        #region Atributos
        private IContratoAgregarMusculo _vistaAgregarMusculo;
        #endregion

        #region Constructor con Inyeccion
        public PAgregarMusculo(IContratoAgregarMusculo vistaAgregarMusculo)
        {
            _vistaAgregarMusculo = vistaAgregarMusculo;
        }
        #endregion

        #region Metodo
        public void AgregarMusculo(String nombre, String descripcion)
        {
            String nombreMusculoAgregar = _vistaAgregarMusculo.nombreMusculo;
            bool flag1 = false, flag2 = false; ;
            flag1 = FabricaComando.CrearComandoValidarCampo(_vistaAgregarMusculo.nombreMusculo).Ejecutar();
            flag2 = FabricaComando.CrearComandoValidarCampo(_vistaAgregarMusculo.descripcionMusculo).Ejecutar();
            
            if ((flag1) && (flag2))
            {

                if (FabricaComando.CrearComandoAgregarMusculo(nombre, descripcion).Ejecutar())
                {
                    _vistaAgregarMusculo.Exito = "Ingreso Exitoso";
                    (_vistaAgregarMusculo as VistaAgregarMusculo).Mensaje.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    _vistaAgregarMusculo.Exito = "Falla al Agregar";
                    (_vistaAgregarMusculo as VistaAgregarMusculo).Mensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                _vistaAgregarMusculo.Exito = "Campos Vacios";
                (_vistaAgregarMusculo as VistaAgregarMusculo).Mensaje.ForeColor = System.Drawing.Color.Red;
            }

            (_vistaAgregarMusculo as VistaAgregarMusculo).Mensaje.Visible = true;

        }
        #endregion
    }
}