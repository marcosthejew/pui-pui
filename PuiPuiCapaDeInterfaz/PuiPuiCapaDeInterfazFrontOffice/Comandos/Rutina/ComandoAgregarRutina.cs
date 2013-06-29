using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoAgregarRutina : AComando<bool>
    {
        string nombre;
        string descripcion;

        public ComandoAgregarRutina(string _nombre, string _descripcion)
        {
            this.nombre = _nombre; ;
            this.descripcion = _descripcion;
        }
        public override bool Ejecutar()
        {
            try
            {
                new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().AgregarRutina(nombre, descripcion);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}