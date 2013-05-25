﻿using System;

namespace PuiPui_BackOffice.LogicaDeNegocios.Excepciones
{
    public class EjercicioException : Exception
    {
        public EjercicioException() { }
        public EjercicioException(string message): base(message) { }
        public EjercicioException(string message, Exception inner): base(message, inner) { }
    }
}