using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PInstructor
{
    public class PAgregarInstructor
    {
        private IContratoAgregarInstructor _vista;

        public PAgregarInstructor(IContratoAgregarInstructor vista)
        {
            _vista = vista;
        }

        public void ManejarClick()
        {
            string cedula = _vista.cedulaInstructor;
            string primerNombre = _vista.primerNombreInstructor;
            string segundoNombre = _vista.segundoNombreInstructor;
            string primerApellido = _vista.primerApellidoInstructor;
            string segundoApellido = _vista.segundoApellidoInstructor;
            /*String sexo = _vista.sexoInstructor;
            String fechaNacimiento = _vista.fechaNacimientoInstructor;
            String fechaIngreso = _vista.fechaIngresoInstructor;
            String entidadFederal = _vista.entidadFederalInstructor;*/
            string ciudad = _vista.ciudadInstructor;
            String direccion = _vista.direccionInstructor;
            String telefonoLocal = _vista.telefonoLocalInstructor;
            String telefonoCelular = _vista.telefonoCelularInstructor;
            String correo = _vista.correoInstructor;
            /*String horario = _vista.horarioInstructor;
            String nombreContacto = _vista.nombreContactoInstructor;
            String telefonoContacto = _vista.telefonoContactoInstructor;
            String status = _vista.statusInstructor;*/
        }
    }
}