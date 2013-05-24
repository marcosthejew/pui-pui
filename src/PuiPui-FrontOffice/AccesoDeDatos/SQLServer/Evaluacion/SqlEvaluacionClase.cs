using PuiPui_FrontOffice.Entidades.ClaseSalon;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SqlEvaluacionClase
    {

        private string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

        private static String DEFAULT_QUERY_CONSULTA_CLASE_SALON = "SELECT CS.id_clase_salon, CS.id_clase, CS.id_salon, CS.id_instructor, C.nombre, S.ubicacion, I.primer_nombre, I.primer_apellido  " +
                                                                    "FROM Clase_Salon CS "+
                                                                    "JOIN Clase C ON (C.id_clase = CS.id_clase) "+
                                                                    "JOIN Salon S ON (S.id_salon = CS.id_salon) "+
                                                                    "JOIN Instructor I on (I.id_instructor = CS.id_salon) "+
                                                                    "WHERE CS.isReservado = 1";

        public List<ClaseSalon> consultarClaseEvaluacion()
        {
            List<ClaseSalon> listaEvaluaciones = new List<ClaseSalon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conexion = new SqlConnection(_cadenaConexion);
            conexion.Open();
            cmd = new SqlCommand(DEFAULT_QUERY_CONSULTA_CLASE_SALON, conexion);

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int idClaseSalon = Convert.ToInt16(dataReader["id_clase_salon"].ToString());
                int idClase = Convert.ToInt16(dataReader["id_clase"].ToString());
                int idSalon = Convert.ToInt16(dataReader["id_salon"].ToString());
                int idInstructor = Convert.ToInt16(dataReader["id_instructor"].ToString());
                String nombreClase = dataReader["nombre"].ToString();
                String ubicacionSalon = dataReader["ubicacion"].ToString();
                String primerNombre = dataReader["primer_nombre"].ToString();
                String primerApellido = dataReader["primer_apellido"].ToString();
           
                ClaseSalon claseSalon = new ClaseSalon();

                claseSalon.IdClaseSalon = idClaseSalon;
                claseSalon.FkIdClase.IdClase = idClase;
                claseSalon.FkIdSalon.IdSalon = idSalon;
                claseSalon.FkIdInstructor.IdPersona = idInstructor;
                claseSalon.FkIdClase.Nombre = nombreClase;
                claseSalon.FkIdSalon.Ubicacion = ubicacionSalon;
                claseSalon.FkIdInstructor.ApellidoPersona1 = primerApellido;
                claseSalon.FkIdInstructor.NombrePersona1 = primerNombre;

                listaEvaluaciones.Add(claseSalon);
            }

            dataReader.Close();
            
            return listaEvaluaciones;
        }
    }
}