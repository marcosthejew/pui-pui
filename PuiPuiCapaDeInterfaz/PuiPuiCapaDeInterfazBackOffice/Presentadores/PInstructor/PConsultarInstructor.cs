using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PInstructor
{
    public class PConsultarInstructor
    {
        private IContratoConsultarInstructor _vista;

        public PConsultarInstructor(IContratoConsultarInstructor vista)
        {
            _vista = vista;
        }

        public void Consultar()
        {
            String cedula = _vista.cedulaInstructor;
            String primerNombre = _vista.primerNombreInstructor;
            String segundoNombre = _vista.segundoNombreInstructor;
            String primerApellido = _vista.primerApellidoInstructor;
            String segundoApellido = _vista.segundoApellidoInstructor;
            String sexo = _vista.sexoInstructor;
            String fechaNacimiento = _vista.fechaNacimientoInstructor;
            String fechaIngreso = _vista.fechaIngresoInstructor;
            String entidadFederal = _vista.entidadFederalInstructor;
            String ciudad = _vista.ciudadInstructor;
            String direccion = _vista.direccionInstructor;
            String telefonoLocal = _vista.telefonoLocalInstructor;
            String telefonoCelular = _vista.telefonoCelularInstructor;
            String correo = _vista.correoInstructor;
            String horario = _vista.horarioInstructor;
            String nombreContacto = _vista.nombreContactoInstructor;
            String telefonoContacto = _vista.telefonoContactoInstructor;
            String status = _vista.statusInstructor;
        }
    }
}