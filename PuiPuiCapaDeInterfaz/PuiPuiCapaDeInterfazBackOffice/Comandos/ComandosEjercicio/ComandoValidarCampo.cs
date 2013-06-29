using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoValidarCampo:AComando<bool>
    {
        string _valor;
        public ComandoValidarCampo(String valor)
        {
            _valor = valor;
        }
        public override bool Ejecutar()
        {
            bool flag = true;
            if ((_valor == null) || (_valor == ""))
            {
                flag = false;
            }
            return flag;
        }
    }
}