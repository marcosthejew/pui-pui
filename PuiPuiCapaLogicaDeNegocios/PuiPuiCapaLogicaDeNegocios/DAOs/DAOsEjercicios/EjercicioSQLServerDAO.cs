﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la
    /// entidad Ejercicio en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class EjercicioSQLServerDAO : ASQLServerDAO, IEjercicioDAO
    {
        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Ejercicio que
        /// se encuentran en la base de datos de SQL Server de la capa de datos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.AEntidad> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Devuelve la entidad de Ejercicio activa que se encuentra en la base
        /// de datos de SQL Server de la capa de datos correspondiente al id
        /// especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Ejercicio que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Agrega una entidad de Ejercicio a la base de datos de SQL Server de
        /// la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(Entidades.AEntidad entidad)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inactiva el registro de la entidad Ejercicio correspondiente al id
        /// espeficidado de la base de datos de SQL Server de la capa de datos.
        /// En caso de exito, retorna true. De lo contrario, false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad que se desea inactivar.
        /// </param>
        /// <returns></returns>
        public bool Inactivar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifica la entidad de Ejercicio correspondiente al id especificado
        /// con la informacion suministrada en la entidad especificada. En caso
        /// de exito, retorna true. De lo contrario, false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Ejercicio que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            throw new NotImplementedException();
        }
    }
}