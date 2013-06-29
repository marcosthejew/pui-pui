using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsPersonas
{
    /// <summary>
    /// Interfaz que implementa todas las operaciones de datos pertinentes a la
    /// entidad Instructor.
    /// </summary>
    public interface IInstructorDAO : IPersonaDAO
    {
        bool Agregar(int a, Entidades.AEntidad entidad);
        bool Modificar(Entidades.AEntidad entidad);
        bool ExisteInstructor(Entidades.AEntidad entidad);
        List<AEntidad> ConsultarInstructoresActivos();
    }
}
