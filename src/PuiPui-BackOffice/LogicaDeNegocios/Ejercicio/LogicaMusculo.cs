using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;


namespace PuiPui_BackOffice.LogicaDeNegocios.Ejercicio
{
    public class LogicaMusculo
    {
        #region AgregarMusculo
        public bool AgregarMusculo(string nombre)
        {
            SQLServerMusculo objDataBase = new SQLServerMusculo();
            bool exito = false;
            try
            {
                if (objDataBase.ExisteMusculo(nombre))
                    exito = false;
                else
                    exito = objDataBase.InsertarMusculo(nombre);
            }
            catch (MusculoBDException e)
            {
                throw new MusculoException("No se pudo agregar el musculo: "+e.Message, e);
            }
            return exito;
        }
        #endregion AgregarMusculo

        #region ConsultarTodosMusculos
        public List<Entidades.Ejercicio.Musculo> ConsultarTodosMusculos()
        {
            SQLServerMusculo objDataBase = new SQLServerMusculo();
            try
            {
                if (objDataBase.ConsultarMusculos() != null)
                    return objDataBase.ConsultarMusculos();
            }
            catch (MusculoBDException e)
            {
                throw new MusculoException("No se pudo consultar los musculos: " + e.Message, e);
            }
            return null;
        }
        #endregion ConsultarTodosMusculos

        #region EliminarMusculo
        public bool EliminarMusculo(string nombre)
        {
            SQLServerMusculo objDataBase = new SQLServerMusculo();
            bool exito = false;
            try
            {
                int idMusculo = objDataBase.BuscarIdMusculo(nombre);
                if (idMusculo > 0)
                    if (!objDataBase.ExisteEjercicioConMusculo(idMusculo))
                    {
                        objDataBase.EliminarMusculo(idMusculo);
                        exito = true;
                    }
            }
            catch (MusculoBDException e)
            {
                throw new MusculoException("No se pudo eliminar el musculo: " + e.Message, e);
            }
            return exito;
        }
        #endregion EliminarMusculo

    }
}