using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerInstructor
    {
        IConexionSqlServer db = new ConexionSqlServer();

        #region ExisteInstructor
        public bool ExisteInstructor(string tbcedula)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", tbcedula);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    exito = true;

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new InstructorBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InstructorBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new InstructorBDException("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new InstructorBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new InstructorBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return exito;

        }
        #endregion ExisteInstructor

        #region InsertarInstructor
        public bool insertarInstructor(string tbcedula, string tbprimer_nombre, string tbprimer_apellido, long tbtelefono_local, string tbciudad, string tbsegundo_nombre, string tbsegundo_apellido, long tbtelefono_celular, string tbdireccion, string tbemail, string tbpersona_contacto, long tbtelefono, DateTime calendar, string sexo)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[agregarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", tbcedula);
                cmd.Parameters.AddWithValue("@primerNombre", tbprimer_nombre);
                cmd.Parameters.AddWithValue("@segundoNombre", tbsegundo_nombre);
                cmd.Parameters.AddWithValue("@primerApellido", tbprimer_apellido);
                cmd.Parameters.AddWithValue("@segundoApelldo", tbsegundo_apellido);
                cmd.Parameters.AddWithValue("@genero", sexo);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", calendar);
                cmd.Parameters.AddWithValue("@fecha_registro", DateTime.Today);
                cmd.Parameters.AddWithValue("@ciudad", tbciudad);
                cmd.Parameters.AddWithValue("@direccion", tbdireccion);
                cmd.Parameters.AddWithValue("@telefonoLocal", tbtelefono_local);
                cmd.Parameters.AddWithValue("@telefonoCelular", tbtelefono_celular);
                cmd.Parameters.AddWithValue("@correoElectronico", tbemail);
                cmd.Parameters.AddWithValue("@nombreEmergencia", tbpersona_contacto);
                cmd.Parameters.AddWithValue("@contactoEmergencia", tbtelefono);
                cmd.Parameters.AddWithValue("@status", "Activo");
                dr = cmd.ExecuteReader();

                exito = true;
                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new InstructorBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InstructorBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new InstructorBDException("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new InstructorBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new InstructorBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return exito;
        }
        #endregion InsertarInstructor

        #region ConsultarInstructores
        public List<Instructor> ConsultarInstructores()
        {
           // string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosInstructores]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                List<Instructor> instructores = new List<Instructor>();

                bool entra = false;

                while (dr.Read())
                {
                    entra = true;
                    Instructor instructor = new Instructor();
                    instructor.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    instructor.CedulaPersona = Convert.ToInt32(dr.GetValue(1));
                    instructor.NombrePersona1 = dr.GetValue(2).ToString();
                    instructor.ApellidoPersona1 = dr.GetValue(3).ToString();
                    instructores.Add(instructor);
                }
                db.CerrarConexion();
                if (entra)
                    return instructores;
            }
            catch (ArgumentException e)
            {
                throw new InstructorBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InstructorBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new InstructorBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new InstructorBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new InstructorBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return null;
        }
        #endregion ConsultarInstructores

        #region ConsultarInstructor
        public Instructor ConsultarIntructor(string cedula)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", cedula);
                dr = cmd.ExecuteReader();
                Instructor instructor1 = new Instructor();

                if (dr.Read())
                {
                    instructor1.CedulaPersona = Convert.ToInt32(dr.GetValue(0));
                    instructor1.NombrePersona1 = dr.GetValue(1).ToString();
                    instructor1.NombrePersona2 = dr.GetValue(2).ToString();
                    instructor1.ApellidoPersona1 = dr.GetValue(3).ToString();
                    instructor1.ApellidoPersona2 = dr.GetValue(4).ToString();
                    instructor1.GeneroPersona = dr.GetValue(5).ToString();
                    instructor1.FechaNacimientoPersona = DateTime.Parse(dr.GetValue(6).ToString());
                    instructor1.FechaIngresoPersona = DateTime.Parse(dr.GetValue(7).ToString());
                    instructor1.CiudadPersona = dr.GetValue(8).ToString();
                    instructor1.DireccionPersona = dr.GetValue(9).ToString();
                    instructor1.TelefonoLocalPersona = dr.GetValue(10).ToString();
                    instructor1.TelefonoCelularPersona = dr.GetValue(11).ToString();
                    instructor1.CorreoPersona = dr.GetValue(12).ToString();
                    instructor1.ContactoNombrePersona = dr.GetValue(13).ToString();
                    instructor1.ContactoTelefonoPersona = dr.GetValue(14).ToString();
                    instructor1.EstadoPersona = dr.GetValue(15).ToString();
                }
                db.CerrarConexion();
                SQLServerHorario obj = new SQLServerHorario();
                if (obj.ConsultarHorarios(dr.GetValue(0).ToString()) != null)
                    instructor1.Horario = obj.ConsultarHorarios(cedula);

                return instructor1;
            }
            catch (ArgumentException e)
            {
                throw new InstructorBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InstructorBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new InstructorBDException("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new InstructorBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new InstructorBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
        }
        #endregion ConsultarInstructor

        #region EliminarInstructor
        public bool EliminarInstructor(string cedula) 
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[eliminarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", cedula);
                dr = cmd.ExecuteReader();

                exito = true;
                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new InstructorBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InstructorBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new InstructorBDException("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new InstructorBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new InstructorBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return exito;

        }
        #endregion EliminarInstructor

        #region ConsultarInstructoresActivos
        public List<Instructor> ConsultarInstructoresActivos()
        {
            // string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosInstructoresActivos]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                List<Instructor> instructores = new List<Instructor>();

                bool entra = false;

                while (dr.Read())
                {
                    entra = true;
                    Instructor instructor = new Instructor();
                    instructor.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    instructor.CedulaPersona = Convert.ToInt32(dr.GetValue(1));
                    instructor.NombrePersona1 = dr.GetValue(2).ToString();
                    instructor.ApellidoPersona1 = dr.GetValue(3).ToString();
                    instructores.Add(instructor);
                }
                db.CerrarConexion();
                if (entra)
                    return instructores;
            }
            catch (ArgumentException e)
            {
                throw new InstructorBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InstructorBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new InstructorBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new InstructorBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new InstructorBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return null;
        }
        #endregion ConsultarInstructoresActivos

        

        

        

        #region ActualizarIntructor
        public void ActualizarIntructor(Instructor instructor, int id)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[actualizarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cedula", instructor.CedulaPersona.ToString());
                cmd.Parameters.AddWithValue("@primerNombre", instructor.NombrePersona1.ToString());
                cmd.Parameters.AddWithValue("@segundoNombre", instructor.NombrePersona2.ToString());
                cmd.Parameters.AddWithValue("@primerApellido", instructor.ApellidoPersona1.ToString());
                cmd.Parameters.AddWithValue("@segundoApelldo", instructor.ApellidoPersona2.ToString());
                cmd.Parameters.AddWithValue("@genero", instructor.GeneroPersona.ToString());
                cmd.Parameters.AddWithValue("@fecha_nacimiento", instructor.FechaNacimientoPersona);
                cmd.Parameters.AddWithValue("@ciudad", instructor.CiudadPersona.ToString());
                cmd.Parameters.AddWithValue("@direccion", instructor.DireccionPersona.ToString());
                cmd.Parameters.AddWithValue("@telefonoLocal", long.Parse(instructor.TelefonoLocalPersona));
                cmd.Parameters.AddWithValue("@telefonoCelular", long.Parse(instructor.TelefonoCelularPersona));
                cmd.Parameters.AddWithValue("@correoElectronico", instructor.CorreoPersona.ToString());
                cmd.Parameters.AddWithValue("@nombreEmergencia", instructor.ContactoNombrePersona.ToString());
                cmd.Parameters.AddWithValue("@contactoEmergencia", long.Parse(instructor.ContactoTelefonoPersona));
                cmd.Parameters.AddWithValue("@status", instructor.EstadoPersona.ToString());

                dr = cmd.ExecuteReader();
                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new InstructorBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InstructorBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new InstructorBDException("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new InstructorBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new InstructorBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }

        }
        #endregion ActualizarIntructor


    }
}