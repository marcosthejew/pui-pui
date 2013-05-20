using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.Entidades.Rutina;
using PuiPui_FrontOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;
using PuiPui_BackOffice.Entidades;
namespace PuiPui_FrontOffice.LogicaDeNegocios.Rutinas

{
    public class LogicaRutina
    {
     
        private Rutina logirutina = new Rutina();

        /*Metodo para insertar una Rutina*/
        public bool InsertaRutina(string _descripcion, DateTime _duracion_rutina, int _repeticiones)
        {
           logirutina= new Rutina(_descripcion,_duracion_rutina, _repeticiones);
           SQLServerRutina _insertaRutina = new SQLServerRutina();
          bool _inserto = false;
          _inserto=_insertaRutina.BDInsertarRutina(logirutina);
          return _inserto;
        
        
        }

        /*Metodo para obtener  una Rutina*/

        public List<Rutina> ConsultaRutina(int id_rutina)
        {
            List<Rutina> _rutinas = new List<Rutina>();
            SQLServerRutina _insertaRutina = new SQLServerRutina();
            _rutinas = _insertaRutina.BDConsultaRutinas(id_rutina);
            return _rutinas;
        
        }
     

        public List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio> ConsultaTodoEjercicios()
        {
            List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio> _listaejercicios = new List<PuiPui_BackOffice.Entidades.Ejercicio.Ejercicio>();
            PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio _ejercicios = new PuiPui_BackOffice.AccesoDeDatos.SQLServer.SQLServerEjercicio();
            _listaejercicios = _ejercicios.ConsultarEjercicios();
            return _listaejercicios;

        
        
        }
        public Rutina Logirutina
        {
            get { return logirutina; }
            set { logirutina = value; }
        }
    }
}