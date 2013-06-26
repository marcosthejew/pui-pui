using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon;
namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    public class FabricaComandosSalon
    {
        public static AComando<List<Salon>> 
        CrearComandoConsultarTodosSalones()
        {
            return new ComandoConsultarTodosSalones();
        }

        public static AComando<Salon>
        CrearComandoConsultarSalonesPorId(int id)
        {
            return new ComandoConsultarSalonesPorId(id);
        }


        public static AComando<int> CrearComandoAgregarSalon(Salon salon)
        {
            return new ComandoAgregarSalon(salon);
        }

        public static AComando<bool> CrearComandoInactivarSalon(int id)
        {
            return new ComandoInactivarSalon(id);
        }
        public static AComando<bool> CrearComandoModificarSalon(int id, Salon salon)
        {
            return new ComandoModificarSalon(id,salon);
        }
        public static AComando <List<Salon>>
        CrearComandoBusquedaUbicacionSalones(String ubicacion)
        {
            return new ComandoBusquedaUbicacionSalones(ubicacion);
        }
        public static AComando<List<Salon>>
        CrearComandoBusquedaCapacidadMayorSalon(int capacidad)
        {
            return new ComandoBusquedaCapacidadMayorSalon(capacidad);

        }

        public static AComando<List<Salon>>
        CrearComandoBusquedaCapacidadMenorSalon(int capacidad)
        {
            return new ComandoBusquedaCapacidadMenorSalon(capacidad);
        }

        public static AComando<List<Salon>>
        CrearComandoBusquedaStatusSalon(int status)
        {
            return new ComandoBusquedaStatusSalon(status);
        }

    }
}