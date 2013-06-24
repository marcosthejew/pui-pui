using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios
{
    /// <summary>
    /// Interfaz que implementa todas las operaciones de datos pertinentes a la
    /// entidad Ejercicio.
    /// </summary>
    public interface IEjercicioDAO : IDAO
    {
        bool Modificar(AEntidad entidad);
        bool Agregar(int a,AEntidad entidad);
        bool ExisteEjercicio(AEntidad ejercicio);
        bool ExisteEjercicioOtroId(AEntidad ejercicio);
        bool ExisteRutinaConEjercicio(AEntidad ejercicio);
    }
}
