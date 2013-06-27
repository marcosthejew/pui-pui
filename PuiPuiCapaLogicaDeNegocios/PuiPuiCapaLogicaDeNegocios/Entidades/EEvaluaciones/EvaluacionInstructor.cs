﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones
{
    public class EvaluacionInstructor : AEvaluacion
    {
        #region Atributos
            private int _idEvaluacion;
            private DateTime _fecha;
            private String _observaciones;
            private int _inactivo;
            private int _id_Cliente;
            private int _id_Instructor;
        #endregion

        #region Getter Setter

            public int idEvaluacion
            {
                get { return _idEvaluacion; }
                set { _idEvaluacion = value; }
            }

            public DateTime Fecha
            {
                get { return _fecha; }
                set { _fecha = value; }
            }
            public String Observaciones
            {
                get { return _observaciones; }
                set { _observaciones = value; }
            }
            public int Inactivo
            {
                get { return _inactivo; }
                set { _inactivo = value; }
            }
            public int idCliente
            {
                get { return _id_Cliente; }
                set { _id_Cliente = value; }
            }
            public int idInstructor
            {
                get { return _id_Instructor; }
                set { _id_Instructor = value; }
            }


        #endregion
        #region Metodos
            public string serializar()
            {
                string resultado = "<EvalucionIntructor>";

                resultado += "<Id>" + Id + "</Id>";
                resultado += "<Fecha>" + _fecha + "</Fecha>";
                resultado += "<Observaciones>" + _observaciones + "</Observaciones>";
                resultado += "<Status>" + _inactivo + "</Status>";
                resultado += "<Cliente>" + _id_Cliente + "</Cliente>";
                resultado += "<Instructor>" + _id_Instructor + "</Instructor>";
                resultado += "</EvalucionIntructor>";
                return resultado;

            }
        #endregion
    }
}