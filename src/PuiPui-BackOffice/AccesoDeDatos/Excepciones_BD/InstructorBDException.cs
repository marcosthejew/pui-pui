﻿using System;


namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class InstructorBDException : Exception
    {
        public InstructorBDException() { }
        public InstructorBDException(string message): base(message) { }
        public InstructorBDException(string message, Exception inner): base(message, inner) { }
    }
}