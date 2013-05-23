﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExcepcionConexion : System.Exception
    {
        public ExcepcionConexion() : base() { }
        public ExcepcionConexion(string message) : base(message) { }
        public ExcepcionConexion(string message, System.Exception inner) : base(message, inner) { }
    }
}