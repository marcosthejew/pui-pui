using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandasoClaseSalon;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    public class FabricaComandoClaseSalon
    {
        public static AComando<List<ClaseSalon>>
        CrearComandoConsultarClaseSalonTodos()
        {

            return new ComandoConsultarClaseSalonTodos();
        }
        public static AComando<List<ClaseSalon>>
        CrearComandoBusquedaClase(string clase)
        {

            return new ComandoBusquedaClase(clase);
        
        }

        public static AComando<List<ClaseSalon>>
        CrearComandoBusquedaSalon(string salon)
        {
            return new ComandoBusquedaSalon(salon);
        }


        public static AComando<List<ClaseSalon>>
        CrearComandoBusquedaInstructor(string instructor)
        {

            return new ComandoBusquedaInstructor(instructor);
        }
        public static AComando<int>
        CrearComandoInsertarClaseSalon(ClaseSalon claseSalon)
        {

            return new ComandoAgregarClaseSalon(claseSalon);
        }
       public static AComando<string>
        CrearComandoSerializar(List<ClaseSalon> lista)
       {

           return new ComandoSerializarClaseSalon(lista);
       }



    }
}