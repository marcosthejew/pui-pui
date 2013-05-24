using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion;
using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;
using PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD;
using System.Configuration;
namespace PuiPui_FrontOffice.PruebasUnitarias.Rutina
{
    [TestFixture]
    public class PruebaRutina
    {
        

        public static int ObtenerUltimoInsert()
        {
            IConexionSqlServer db = new ConexionSqlServer();
              string _cadenaConexion = "Server= localhost;database=puipuiDB;integrated security=true";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            int resultado = 0;
            String valorAuxiliar = "";
            try
            {
                conexion = new SqlConnection(_cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("SELECT max(id_rutina) from rutina;", conexion);
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    valorAuxiliar = dr.GetValue(0).ToString();
                    resultado = Convert.ToInt32(valorAuxiliar);

                }
                db.CerrarConexion();
                return resultado;
            }

            catch (Exception e)
            {
                throw (new ExcepcionConexion(("Error: " + e.Message + valorAuxiliar), e));


            }

            finally
            {
                conexion.Close();
                
            }
            return resultado;
        }

       
        [Test]
        public void PruebaInsertaRutina() {
            String descripcion = "rutina prueba";
            DateTime duracionRutina = new DateTime(2013,5,22,4,8,12);
            int repeticiones = 5;
            LogicaDeNegocios.Rutinas.LogicaRutina logicaRutinaPrueba=new  LogicaDeNegocios.Rutinas.LogicaRutina();
          bool resultadoEsperado= logicaRutinaPrueba.InsertaRutina(descripcion, duracionRutina, repeticiones);
           Assert.True(resultadoEsperado);
           
        }

        [Test]
        public void PruebaConsultaRutina()
        {   
            LogicaDeNegocios.Rutinas.LogicaRutina logicaRutinaPrueba = new LogicaDeNegocios.Rutinas.LogicaRutina();
            AccesoDeDatos.SQLServer.SQLServerRutina ConexionADatosRutina = new AccesoDeDatos.SQLServer.SQLServerRutina();
            int idInsert = PruebaRutina.ObtenerUltimoInsert();
            Entidades.Rutina.Rutina rutinaAuxiliar = logicaRutinaPrueba.ConsultaRutina(idInsert);
            int auxiliar = rutinaAuxiliar.Repeteciones;
            Assert.AreEqual(auxiliar,5);
        }
        [Test]
        public void PruebaUpdateRutina()
        {
            DateTime duracionRutina = new DateTime(2013,05,22,01,30,00);
            LogicaDeNegocios.Rutinas.LogicaRutina logicaRutinaPrueba = new LogicaDeNegocios.Rutinas.LogicaRutina();
            AccesoDeDatos.SQLServer.SQLServerRutina ConexionADatosRutina = new AccesoDeDatos.SQLServer.SQLServerRutina();
            int idInsert = PruebaRutina.ObtenerUltimoInsert();
            Entidades.Rutina.Rutina rutina = new Entidades.Rutina.Rutina(idInsert, "rutina prueba", duracionRutina, 7);
            bool resultadoEsperado = logicaRutinaPrueba.Update_Rutina(rutina);
            Entidades.Rutina.Rutina rutinaAuxiliar = logicaRutinaPrueba.ConsultaRutina(idInsert);
            int auxiliar = rutinaAuxiliar.Repeteciones;
            Assert.AreEqual(auxiliar,7);
            rutina.Repeteciones = 5;
            logicaRutinaPrueba.Update_Rutina(rutina);
        }

        
        [Test]
        public void PruebaInsertaHistorial()
        {
            LogicaDeNegocios.Rutinas.LogicaRutina logicaRutinaAuxiliar = new LogicaDeNegocios.Rutinas.LogicaRutina();
            AccesoDeDatos.SQLServer.SQLServerHistorialEjercicios buscaEjercicios = new AccesoDeDatos.SQLServer.SQLServerHistorialEjercicios();
            int idInsert = PruebaRutina.ObtenerUltimoInsert();
            bool resultadoEsperado = logicaRutinaAuxiliar.Inserta_Historial(1,idInsert,1);
            Assert.True(resultadoEsperado);
        }

        [Test]
        public void PruebaEliminaHistorico()
        {
            LogicaDeNegocios.Rutinas.LogicaRutina logicaRutinaAuxiliar = new LogicaDeNegocios.Rutinas.LogicaRutina();
            int idInsert = PruebaRutina.ObtenerUltimoInsert();
            bool resultadoEsperado = logicaRutinaAuxiliar.Elimina_Historico(1, idInsert);
            Assert.True(resultadoEsperado);
        }

        [Test]
        public void PruebaTodasRutinas()
        {
            LogicaDeNegocios.Rutinas.LogicaRutina logicaRutinaAuxiliar = new LogicaDeNegocios.Rutinas.LogicaRutina();

            List<Entidades.Rutina.Rutina> resultadoEsperado = logicaRutinaAuxiliar.TodasRutinas();
            Assert.NotNull(resultadoEsperado);
        }

        [Test]
        public void PruebaConstructoresRutina()
        {
            Entidades.Rutina.Rutina rutinaAuxiliar1 = new Entidades.Rutina.Rutina(1000);
            Assert.NotNull(rutinaAuxiliar1);
            Entidades.Rutina.Rutina rutinaAuxiliar2 = new Entidades.Rutina.Rutina("descripcion", new DateTime(1998, 12, 12));
            Assert.NotNull(rutinaAuxiliar2);
            Entidades.Rutina.Rutina rutinaAuxiliar3 = new Entidades.Rutina.Rutina("descripcion", new DateTime(1998, 12, 12), 5);
            Assert.NotNull(rutinaAuxiliar3);
            Entidades.Rutina.Rutina rutinaAuxiliar4 = new Entidades.Rutina.Rutina(1000, "descripcion", new DateTime(1998, 12, 12), 5);
            Assert.NotNull(rutinaAuxiliar4);
        }

        [Test]
        public void PruebaConstructoresHistorialEjercicio()
        {
            Entidades.Rutina.Historial_Ejercicio HistorialAuxiliar1 = new Entidades.Rutina.Historial_Ejercicio(1000);
            Assert.NotNull(HistorialAuxiliar1);
            Entidades.Rutina.Historial_Ejercicio HistorialAuxiliar2 = new Entidades.Rutina.Historial_Ejercicio(1000, 1);
            Assert.NotNull(HistorialAuxiliar2);
            Entidades.Rutina.Historial_Ejercicio HistorialAuxiliar3 = new Entidades.Rutina.Historial_Ejercicio(1000, 1, 1);
            Assert.NotNull(HistorialAuxiliar3);
            Entidades.Rutina.Historial_Ejercicio HistorialAuxiliar4 = new Entidades.Rutina.Historial_Ejercicio();
            Assert.NotNull(HistorialAuxiliar4);
        }
                                                                                                                                                                                            

   
    }
}