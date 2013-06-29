using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor
{
    public interface IContratoModificarInstructor
    {
        String sesionId { get; set; }
        String cedulaInstructor { get; set; }
        String primerNombreInstructor { get; set; }
        String segundoNombreInstructor { get; set; }
        String primerApellidoInstructor { get; set; }
        String segundoApellidoInstructor { get; set; }
        String sexoInstructor { get; set; }
        String fechaNacimientoInstructor { get; set; }
        String fechaIngresoInstructor { get; set; }
        String entidadFederalInstructor { get; set; }
        String ciudadInstructor { get; set; }
        String direccionInstructor { get; set; }
        String telefonoLocalInstructor { get; set; }
        String telefonoCelularInstructor { get; set; }
        String correoInstructor { get; set; }
        String horarioInstructor { get; set; }
        String nombreContactoInstructor { get; set; }
        String telefonoContactoInstructor { get; set; }
        String statusInstructor { get; set; }
    }
}
