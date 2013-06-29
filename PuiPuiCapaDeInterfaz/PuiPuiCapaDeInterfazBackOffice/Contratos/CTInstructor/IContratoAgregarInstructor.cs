using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor
{
    public interface IContratoAgregarInstructor
    {
        string cedulaInstructor { get; set; }
        string primerNombreInstructor { get; set; }
        string segundoNombreInstructor { get; set; }
        string primerApellidoInstructor { get; set; }
        string segundoApellidoInstructor { get; set; }
        /*string sexoInstructor { get; set; }
        string fechaNacimientoInstructor { get; set; }
        string fechaIngresoInstructor { get; set; }
        string entidadFederalInstructor { get; set; }*/
        string ciudadInstructor { get; set; }
        string direccionInstructor { get; set; }
        string telefonoLocalInstructor { get; set; }
        string telefonoCelularInstructor { get; set; }
        string correoInstructor { get; set; }
        /*string horarioInstructor { get; set; }
        string nombreContactoInstructor { get; set; }
        string telefonoContactoInstructor { get; set; }
        string statusInstructor { get; set; }*/
        string Exito { get; set; }
    }
}
