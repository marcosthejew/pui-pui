using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;

namespace PuiPui_FrontOffice.LogicaDeNegocios.Cliente
{
    public class LogicaPersona
    {
        #region ConsultarPersona
        public List<Persona> ConsultarPersona()
        {

            List<Persona> miListaPersona = new List<Persona>();
            SQLServerPersona objDataBase = new SQLServerPersona();
            miListaPersona = objDataBase.ConsultarPersona();
            return miListaPersona;
        }
        #endregion

        #region ConsultarDetallePersona
        public Persona ConsultarDetallePersona(int idPersona)
        {
            Persona miPersona = new Persona();
            SQLServerPersona objDataBase = new SQLServerPersona();
            miPersona = objDataBase.ConsultarDetallePersona(idPersona);
            return miPersona;
        }
        #endregion

        #region Agregar Cliente
        public Persona AgregoCliente(Persona miPersona)
        {
            Persona objPersona = new Persona();
            SQLServerPersona objDataBase = new SQLServerPersona();
            objPersona = objDataBase.AgregarCliente(miPersona);
            return objPersona;
        }
        #endregion

        #region ModificarPersona
        public void ModificarPersona(Persona nuevaPersona)
        {
            SQLServerPersona objDataBase = new SQLServerPersona();
            bool booleanito = objDataBase.ModificarPersona(nuevaPersona);

        }
        #endregion

        #region ConsultarActivarDesactivarPersona
        public List<Persona> ConsultarActivarDesactivarPersona()
        {
            List<Persona> miListaPersona = new List<Persona>();
            SQLServerPersona objDataBase = new SQLServerPersona();
            miListaPersona = objDataBase.ConsultarActivarDesactivarPersona();
            return miListaPersona;
        }
        #endregion

        #region CambiarEstado
        public void CambiarEstado(Persona persona)
        {
            if (persona.EstadoPersona.Contains("Activo"))
                persona.EstadoPersona = "Inactivo";
            else if (persona.EstadoPersona.Contains("Inactivo"))
                persona.EstadoPersona = "Activo";

            SQLServerPersona objDataBase = new SQLServerPersona();
            bool booleanito = objDataBase.ActivarDesactivarPersona(persona);
        }
        #endregion

        #region LoginCorrecto
        public bool LoginCorrecto(string usuario, string contraseña)
        {
            Acceso acceso = new Acceso();
            bool persona = false;
            SQLServerPersona sqlserverPersona = new SQLServerPersona();
            acceso.Login = usuario;
            acceso.Password = contraseña;
            persona = sqlserverPersona.ConsultarAccesoPersona(acceso);

            if (persona)

                return true;

            return false;
        }
        #endregion

        #region ConsultarPersonaPorLogin
        public Persona ConsultarPersonaPorLogin(string loginPersona)
        {
            Persona miPersona = new Persona();
            SQLServerPersona objDataBase = new SQLServerPersona();
            miPersona = objDataBase.ConsultarPersonaPorLogin(loginPersona);
            return miPersona;
        }
        #endregion

        #region CambiarContraseña
        public bool CambiarContraseña(Persona persona)
        {
            bool miPersona;
            SQLServerPersona objDataBase = new SQLServerPersona();
            miPersona = objDataBase.CambiarContraseña(persona);
            return miPersona;
        }
        #endregion
    }
}