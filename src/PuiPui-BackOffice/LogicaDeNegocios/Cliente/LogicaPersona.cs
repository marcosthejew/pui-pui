using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;

namespace PuiPui_BackOffice.LogicaDeNegocios.Cliente
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
        public Persona AgregoCliente (Persona miPersona)
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

    }
}