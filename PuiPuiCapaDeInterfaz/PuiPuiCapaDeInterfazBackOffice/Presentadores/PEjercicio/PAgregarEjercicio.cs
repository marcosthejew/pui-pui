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
    public class PAgregarEjercicio
    {
        #region Atributos
        private  IAgregarEjercicio _vistaEjercicio;
        #endregion

        #region Constructor Inyector 
        public PAgregarEjercicio(IAgregarEjercicio vistaEjercicio)
        {
            _vistaEjercicio = vistaEjercicio;

        }
        #endregion

        #region Metodos

        public void CargarMusculos()
        {
            FabricaComando.CrearComandoCargarMusculos(_vistaEjercicio);
        }

        public void AgregarEjercicio(string nombre, string descripcion, string musculo)
        {
            bool flag1 =false,flag2 =false,flag3 =false;;
            flag1=FabricaComando.CrearComandoValidarCampo(_vistaEjercicio.Nombre).Ejecutar();
            flag2=FabricaComando.CrearComandoValidarCampo(_vistaEjercicio.Descripcion).Ejecutar();
            flag2=FabricaComando.CrearComandoValidarCampo(_vistaEjercicio.Musculos).Ejecutar();
            if ((flag1) && (flag2) && (flag3))
            {

                if (FabricaComando.CrearComandoAgregarEjercicio(nombre, descripcion, musculo).Ejecutar())
                {
                    _vistaEjercicio.Exito = "Ingreso Exitoso";
                    (_vistaEjercicio as VistaAgregarEjercicio).Mensaje.ForeColor=System.Drawing.Color.Blue;
                }
                else
                {
                    _vistaEjercicio.Exito = "Falla al Agregar";
                    (_vistaEjercicio as VistaAgregarEjercicio).Mensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                _vistaEjercicio.Exito = "Campos Vacios";
                (_vistaEjercicio as VistaAgregarEjercicio).Mensaje.ForeColor = System.Drawing.Color.Red;
            }

            (_vistaEjercicio as VistaAgregarEjercicio).Mensaje.Visible = true;
        }

        #endregion
    }
}