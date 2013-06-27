using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsHorario;
using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosHorario
{

        /// <summary>
        /// Comando que inserta un nuevo horario.
        /// </summary>
        public class ComandoInsertaHorario : AComando<int>
        {
            private Horario horario;

            public ComandoInsertaHorario(Horario horario)
            {
                this.horario = horario;
            }

            /// <summary>
            /// Ejecuta el comando.
            /// </summary>
            /// <returns></returns>
            public override int Ejecutar()
            {
                int agrego = 1;
                IHorarioDAO salonDao = (IHorarioDAO)
                AFabricaDAO.CrearFabricaSQLServerDAO().CrearHorarioSQLServerDAO();
                agrego = salonDao.Agregar(this.horario);
                return (agrego);

            }
        }
    }
