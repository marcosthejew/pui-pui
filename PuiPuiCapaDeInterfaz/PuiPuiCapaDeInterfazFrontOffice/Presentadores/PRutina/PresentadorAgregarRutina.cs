using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTRutina;
using PuiPuiCapaDeInterfazFrontOffice.Comandos;
using System.Xml;
using System.Data;


namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PRutina
{
    public class PresentadorAgregarRutina
    {
        #region Atributos

        private IContratoAgregarRutina _vista;

        //Acceso acceso;
        string loginPersona;
        int idPersona;


        string ejercicioNoAsociado;
        List<string> ejercicioAsociado;
        AComando<string> comandoEjercicio;
        AComando<bool> comandoRutina;
        AComando<DataTable> comando2Ejercicio;
        string ejercicio;
        string rutina;



        string objEjercicio;


        #endregion


        #region Constructor

        public PresentadorAgregarRutina(IContratoAgregarRutina laVista)
        {
            this._vista = laVista;
        }

        #endregion

        public void PageLoad(object sender, EventArgs e)
        {
            try
            {
                //acceso = (Acceso)Session["loginPersona"];
                //loginPersona = acceso.Login;
                loginPersona = "karla";
                //idPersona = logRutina.ConsultarPersonaPorLogin(loginPersona);
                //idPersona = PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios()

                if (_vista.Rrepeticion.Checked == true)
                {
                    _vista.Trepeticion.Enabled = true;
                    _vista.Tduracion.Enabled = false;
                }
                if (_vista.Rduracion.Checked == true)
                {
                    _vista.Tduracion.Enabled = true;
                    _vista.Trepeticion.Enabled = false;
                }


                ejercicioNoAsociado = GetDataEjercicio();
                CargarListaEjercicioNoAsociado(ejercicioNoAsociado);


            }
            catch (NullReferenceException ex)
            {
                _vista.Lerror.Text = ex.Message;
            }
            catch (Exception ex)
            {
                _vista.Lerror.Text = ex.Message;
            }

        }


        public string GetDataEjercicio()
        {
            string datos;

            try
            {
                datos = new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().ConsultarTodosEjerciciosR();
            }

            catch (Exception e)
            {
                datos = null;
                _vista.Lerror.Text = e.Message;
            }

            return datos;
        }


        public void CargarListaEjercicioNoAsociado(string datos)
        {
            try
            {
                comandoEjercicio = FabricaComando.CrearComandoConsultarEjerciciosTodos();
                string resultadoComando = "";
                resultadoComando = comandoEjercicio.Ejecutar();

                DataTable table = new DataTable();
                comando2Ejercicio = FabricaComando.CrearComandoDeserializarEjercicio(resultadoComando);
                table = comando2Ejercicio.Ejecutar();


                _vista.ejercicioNoAsociado.DataSource = table;



            }
            catch (Exception ex)
            {
                _vista.Lerror.Text = ex.Message;
            }

        }


        public void AgregarEjercicio(int index)
        {


        }

         public void Agregar()
        {
            string nombre = _vista.nombre.Text.TrimEnd();
            string descripcion = _vista.descripcion.Text.TrimEnd();

            comandoRutina = FabricaComando.CrearComandoAgregarRutina(nombre, descripcion);
            bool resultadoComando;


           
            resultadoComando = comandoRutina.Ejecutar();

            
        }


         public void repeticionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!_vista.Rrepeticion.Checked)
            {
                _vista.Trepeticion.Enabled = false;
                _vista.Tduracion.Enabled = false;
            }
            else if (_vista.Rrepeticion.Checked)
            {
                _vista.Trepeticion.Enabled = true;
                _vista.Tduracion.Enabled = false;
            }
        }

         public void duracionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_vista.Rduracion.Checked)
            {
                _vista.Tduracion.Enabled = true;
                _vista.Trepeticion.Enabled = false;
                _vista.Trepeticion.Text = "";
            }
            else if (_vista.Rduracion.Checked)
            {
                _vista.Tduracion.Enabled = false;
                _vista.Trepeticion.Enabled = true;
                _vista.Tduracion.Text = "";

            }
        }

    }
    
}