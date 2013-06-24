using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases
{
    /// <summary>
    /// Interfaz que implementa todas las operaciones de datos pertinentes a la
    /// entidad Salon.
    /// </summary>
    public interface ISalonDAO : IDAO
    {
        public List<Entidades.AEntidad> BusquedaUbicacion(String ubicacion);

        public List<Entidades.AEntidad> BusquedaCapacidadMayorSalon(int capacidad);

        public List<Entidades.AEntidad> BusquedaCapacidadMenorSalon(int stat);

        public List<Entidades.AEntidad> BusquedaStatusSalon(int stat);
    }
}
