using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion;
using System.Data;
namespace PuiPui_FrontOffice.Entidades.Rutina
{
    public class Rutina
    {
        private string descripcion;
        private DateTime tiempo;
        private int repeticiones;
        private int id_rutina;
       
        

           public Rutina()
        {
            this.id_rutina = 0;
            this.repeticiones = 0;
            this.descripcion = "";
        
        }
           
          public Rutina(int id_rutina)
           {
               this.id_rutina = id_rutina;
           }
        public Rutina(string descripcion, DateTime tiempo)
        {
            this.descripcion = descripcion;
            this.tiempo = tiempo;
        }
        public Rutina(int rutina,string descripcion, DateTime tiempo, int repeticione)
        {
            this.id_rutina = rutina;
            this.descripcion = descripcion;
            this.tiempo = tiempo;
            this.repeticiones = repeticione;
        }

        public Rutina(string descripcion, DateTime tiempo, int repeticione)
        {

            this.descripcion = descripcion;
            this.tiempo = tiempo;
            this.repeticiones = repeticione;
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public DateTime Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        

        public int Repeteciones
        {
            get { return repeticiones; }
            set { repeticiones = value; }
        }
        public int Id_rutina
        {
            get { return id_rutina; }
            set { id_rutina = value; }
        }
    }
}