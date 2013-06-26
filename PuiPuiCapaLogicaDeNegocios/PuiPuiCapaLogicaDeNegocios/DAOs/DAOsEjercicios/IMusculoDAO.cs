using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios
{
    /// <summary>
    /// Interfaz que implementa todas las operaciones de datos pertinentes a la
    /// entidad Musculo.
    /// </summary>
    public interface IMusculoDAO : IDAO
    {
        bool Agregar(int x, AEntidad entidad);
        bool ExisteMusculo(string nombreMusculo);
        bool ExisteEjercicioConMusculo(int idMusculo);
    }
}
