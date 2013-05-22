using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Rutina
{
    public class Historial_Ejercicio
    {

        private int id_cliente;
        private int id_rutina;
        private int id_ejercicio;
        public Historial_Ejercicio()
        {

            this.id_cliente = 0;
            this.id_ejercicio = 0;
            this.id_rutina = 0;
        }

        public Historial_Ejercicio(int id_client)
        {
            this.id_cliente = id_client;

        }
        public Historial_Ejercicio(int id_cliente, int id_rutina)
        {
            this.id_cliente = id_cliente;
            this.id_rutina = id_rutina;
       
        
        }
        public Historial_Ejercicio(int id_cliente, int id_rutina,int id_ejercicio)
        {
            this.id_cliente = id_cliente;
            this.id_rutina = id_rutina;
            this.id_ejercicio = id_ejercicio;


        }





        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }


        public int Id_rutina
        {
            get { return id_rutina; }
            set { id_rutina = value; }
        }


        public int Id_ejercicio
        {
            get { return id_ejercicio; }
            set { id_ejercicio = value; }
        }

    }
}