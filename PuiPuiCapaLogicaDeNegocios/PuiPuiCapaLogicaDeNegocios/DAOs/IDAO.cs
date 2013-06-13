using PuiPuiCapaLogicaDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuiPuiCapaLogicaDeNegocios.DAOs
{
    public interface IDAO
    {
        /// <summary>
        /// Consulta todos los registros de la fuente de datos para una entidad
        /// especifica
        /// </summary>
        /// <returns>
        /// Devuelve todos los registros de una clase que estan en la fuente de
        /// datos
        /// </returns>
        List<AEntidad> ConsultarTodos();

        /// <summary>
        /// Consulta el registro de la fuente de datos para una entidad y un id
        /// especificos
        /// </summary>
        /// <param name="id">
        /// El id de la entidad a consultar
        /// </param>
        /// <returns>
        /// Devuelve la entidad correspondiente al id suministrado 
        /// </returns>
        AEntidad ConsultarPorId(int id);

        /// <summary>
        /// Agrega una entidad a la fuente de datos
        /// </summary>
        /// <param name="entidad">
        /// La entidad que se desea agregar a la fuente de datos
        /// </param>
        /// <returns>
        /// Devuelve el id de la entidad agregada a la fuente de datos
        /// </returns>
        int Agregar(AEntidad entidad);

        /// <summary>
        /// Inactiva una entidad de la base de datos
        /// </summary>
        /// <param name="id">
        /// El id de la entidad que se va a inactivar
        /// </param>
        /// <returns>
        /// Devuelve true si la transaccion fue exitosa. De lo contrario 
        /// devuelve false
        /// </returns>
        bool Inactivar(int id);

        /// <summary>
        /// Modifica una entidad en la fuente de datos
        /// </summary>
        /// <param name="id">
        /// El id de la entidad que se desea modificar en la base de datos
        /// </param>
        /// <param name="entidad">
        /// La entidad que contiene los nuevos datos
        /// </param>
        /// <returns>
        /// Devuelve true si la transaccion fue exitosa. De lo contrario devuelve
        /// false
        /// </returns>
        bool Modificar(int id, AEntidad entidad);
    }
}
