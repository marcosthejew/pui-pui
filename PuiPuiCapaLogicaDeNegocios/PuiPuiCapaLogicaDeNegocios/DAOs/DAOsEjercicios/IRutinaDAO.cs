using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios
{
    /// <summary>
    /// Interfaz que implementa todas las operaciones de datos pertinentes a la
    /// entidad Rutina.
    /// </summary>
    public interface IRutinaDAO : IDAO
    {
        List<Rutina> ConsultarRutinasPorIDCliente(int idCliente);
        List<Ejercicio> ConsultarEjerciciosPorIDRutina(int idRutina);
        bool ActivarInactivarRutina(int idRutina, byte inactivo);
    }
}
