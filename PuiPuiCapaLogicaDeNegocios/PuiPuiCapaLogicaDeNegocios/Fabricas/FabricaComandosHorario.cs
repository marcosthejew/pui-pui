using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosHorario;
using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    public class FabricaComandosHorario
    {

        public static AComando<int> CrearComandoAgregarSalon(Horario horario)
        {
            return new ComandoInsertaHorario(horario);
        }

    }
}