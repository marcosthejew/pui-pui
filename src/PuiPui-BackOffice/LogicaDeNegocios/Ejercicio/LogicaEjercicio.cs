using System.Collections.Generic;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;
namespace PuiPui_BackOffice.LogicaDeNegocios.Ejercicio
{
    public class LogicaEjercicio
    {

        #region AgregarEjercicio
        public bool AgregarEjercicio(string nombre, string descripcion, string nombreMusculo)
        { //Buscar el id del musculo
            SQLServerMusculo objMusculo = new SQLServerMusculo(); 
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            bool exito = false;
            try
            {
                if (objDataBase.ExisteEjercicio(nombre))
                    exito = false;
                else
                    exito = objDataBase.InsertarEjercicio(nombre, descripcion, objMusculo.BuscarIdMusculo(nombreMusculo));
            }
            catch (EjercicioBDException e)
            {
                throw new EjercicioException("No se pudo agregar el ejercicio: " + e.Message, e);
            }
            return exito;
        }
        #endregion AgregarEjercicio

        #region ConsultarTodosEjercicios
        public List<Entidades.Ejercicio.Ejercicio> ConsultarTodosEjercicios()
        {
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            try
            {
                if (objDataBase.ConsultarEjercicios() != null)
                    return objDataBase.ConsultarEjercicios();
            }
            catch (EjercicioBDException e)
            {
                throw new EjercicioException("No se pudieron consultar los ejercicios: " + e.Message, e);
            }
            return null;
        }
        #endregion ConsultarTodosEjercicios

        #region ConsultarEjericio
        public Entidades.Ejercicio.Ejercicio ConsultarEjercicio(string nombre)
        {
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            try
            {
                if (objDataBase.ConsultarEjercicio(nombre) != null)
                    return objDataBase.ConsultarEjercicio(nombre);
            }
            catch (EjercicioBDException e)
            {
                throw new EjercicioException("No se pudo consultar el ejercicio: " + e.Message, e);
            }
            return null;
        }
        #endregion ConsultarEjercicio

        #region EliminarEjercicio
        public bool EliminarEjercicio(string nombre)
        {
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            try
            {
                if (!objDataBase.ExisteRutinaConEjercicio(nombre))
                {
                    objDataBase.EliminarEjercicio(nombre);
                    return true;
                }
                else
                    return false;
            }
            catch (EjercicioBDException e)
            {
                throw new EjercicioException("No se pudo eliminar el ejercicio: " + e.Message, e);
            }
        }
        #endregion EliminarEjercicio

        #region ActualizarEjercicio
        public bool ActualizarEjercicio(string nombreInicial, Entidades.Ejercicio.Ejercicio ejercicio, string nombreMusculo)
        {
            SQLServerMusculo objDataMusculo = new SQLServerMusculo();
            SQLServerEjercicio objDataBase = new SQLServerEjercicio();
            bool exito = false;
            try
            {
                int idMusculo = objDataMusculo.BuscarIdMusculo(nombreMusculo);
                Entidades.Ejercicio.Ejercicio ejercicioInicial = objDataBase.ConsultarEjercicio(nombreInicial);
                ejercicio.Id = ejercicioInicial.Id;
                if (!objDataBase.ExisteEjercicioOtroId(ejercicio.Nombre, ejercicio.Id))
                {
                    objDataBase.ActualizarEjercicio(ejercicio, idMusculo);
                    exito = true;
                }

            }
            catch (MusculoBDException e)
            {
                throw new EjercicioException("No se pudo actualizar el ejercicio: " + e.Message, e);
            }
            catch (EjercicioBDException e)
            {
                throw new EjercicioException("No se pudo actualizar el ejercicio: " + e.Message, e);
            }
            return exito;
        }
        #endregion ActualizarEjercicio

    }
}