﻿namespace PuiPui_BackOffice.PruebasUnitarias.Excepciones
{
    public class ExcepcionClientes : System.Exception
    {
        public ExcepcionClientes() : base() { }
        public ExcepcionClientes(string message) : base(message) { }
        public ExcepcionClientes(string message, System.Exception inner) : base(message, inner) { }
    }
}