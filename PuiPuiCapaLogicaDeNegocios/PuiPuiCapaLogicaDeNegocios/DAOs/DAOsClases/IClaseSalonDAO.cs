using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases
{
    /// <summary>
    /// Interfaz que implementa todas las operaciones de datos pertinentes a la
    /// entidad ClaseSalon.
    /// </summary>
    public interface IClaseSalonDAO : IDAO
    {
         List<Entidades.AEntidad> ListarSalonesClaseTclase(String nombreClase);
         List<Entidades.AEntidad> ListarSalonesClaseTsalon(String ubicacion);
         List<Entidades.AEntidad> ListarSalonesClaseTinstructor(String instruc);
         List<Entidades.AEntidad> ListarSalonesClaseTdisponible(int stst);
    }
}
