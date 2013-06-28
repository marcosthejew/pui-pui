using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaSalon;
using PuiPuiCapaDeInterfazBackOffice.Contractos.CTSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon
{
    /// <summary>
    /// Estalase tiene como finalidad realizar operaciones referentes a la 
    /// Vista de agregar salon con la capa de Logica de negocios.
    /// </summary>
    public class PAgregarSalon
    {
        IContratoAgregarSalon salon;

        public PAgregarSalon(IContratoAgregarSalon vista_agregar)
        {

            this.salon = vista_agregar;

        }
        /// <summary>
        /// Inserta una salon del GYM en la base de datos pasando por la Logica de negocios
        /// devuelve un booleano depende del caso si se inserto o no
        /// </summary>
        /// <returns>boolean</returns>
        public  bool AgregarSalon()
        {
            FachadaSalonBackOfficeSoapClient agregar = new FachadaSalonBackOfficeSoapClient();
            int se_agrego = agregar.ServicioAgregarSalon(salon.TxtCodigoSalon, salon.TxtNombreSalon, 0, salon.TextCapacidadSalon);

            if (se_agrego == 0)
                return true;
            else
                return false;
        }






    }
}