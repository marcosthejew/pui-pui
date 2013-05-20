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
        public List<Persona> ConsultarModificarPersona()
        {

            List<Persona> miListaPersona = new List<Persona>();
            SQLServerPersona objDataBase = new SQLServerPersona();
            miListaPersona = objDataBase.ConsultarModificarPersona();
            return miListaPersona;
        }

        public Persona ConsultarDetallePersona(int idPersona)
        {

            Persona miPersona = new Persona();
            SQLServerPersona objDataBase = new SQLServerPersona();
            miPersona = objDataBase.ConsultarDetallePersona(idPersona);
            return miPersona;
        }

        public Persona AgregoCliente (Persona miPersona)
        {
            Persona objPersona = new Persona();
            SQLServerPersona objDataBase = new SQLServerPersona();
            objPersona = objDataBase.AgregarCliente(miPersona);
            return objPersona;
        }
        public void ModificarPersona(Persona nuevaPersona)
        {
            SQLServerPersona objDataBase = new SQLServerPersona();
            bool booleanito = objDataBase.ModificarPersona(nuevaPersona);

        }
    }
}