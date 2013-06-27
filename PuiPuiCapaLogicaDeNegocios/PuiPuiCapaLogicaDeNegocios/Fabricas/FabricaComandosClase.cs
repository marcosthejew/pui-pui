using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    public class FabricaComandosClase
    {
        public static AComando<List<Clase>>
   CrearComandoConsultarTodasClases()
        {
            return new ComandoConsultarTodasClases();
        }

        public static AComando<Clase>
        CrearComandoConsultarSalonesPorId(int id)
        {
            return new ComandoConsultarClasesPorId(id);
        }


        public static AComando<int> CrearComandoAgregarClase(Clase clase)
        {
            return new ComandoAgregarClase(clase);
        }

        public static AComando<bool> CrearComandoInactivarClase(int id)
        {
            return new ComandoInactivarClase(id);
        }
        public static AComando<bool> CrearComandoModificarClase(int id, Clase clase)
        {
            return new ComandoModificarClase(id, clase);
        }
        public static AComando<List<Clase>>
        CrearComandoBusquedaNombreClase(String nombre)
        {
            return new ComandoBusquedaNombreClase(nombre);
        }
        
        public static AComando<List<Clase>>
        CrearComandoBusquedaSatusClase(int status)
        {
            return new ComandoBusquedaStatusClase(status);
        }
        public static AComando<string>
        CrearComandoSerializarListaClase(List<Clase> listaClase)
        {
            return new ComandoSerializarListaClase(listaClase);
        }

    }
}