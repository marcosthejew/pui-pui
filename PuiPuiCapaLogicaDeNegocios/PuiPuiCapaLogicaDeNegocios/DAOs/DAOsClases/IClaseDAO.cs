using PuiPuiCapaLogicaDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases
{
    /// <summary>
    /// Interfaz que implementa todas las operaciones de datos pertinentes a la
    /// entidad Clase.
    /// </summary>
    public interface IClaseDAO : IDAO
    {
        List <AEntidad> BusquedaNombreClase(string nombre); 
        List <AEntidad> BusquedaStatusClase(int status);
    }
}
