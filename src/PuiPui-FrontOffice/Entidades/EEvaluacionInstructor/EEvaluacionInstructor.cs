using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.Entidades.Instructor;

namespace PuiPui_FrontOffice.Entidades.EEvaluacionInstructor
{
    public class EEvaluacionInstructor : Evaluacion
    {
        private Instructor.Instructor _instructor = new Instructor.Instructor();

        public Instructor.Instructor Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }
    }
}