using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;

namespace PuiPui_BackOffice.LogicaDeNegocios.Ejercicio
{
    public class LogicaMusculo
    {
        public bool AgregarMusculo(string nombre)
        {

            SQLServerMusculo objDataBase = new SQLServerMusculo();
            if (objDataBase.ExisteMusculo(nombre))
            {
                return true;
            }
            else
            {
                return objDataBase.insertarMusculo(nombre);
            }
           // objDataBase.insertarMusculo
            return false;
        }


    }
}