using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labo11
{
    public class Alumno:Persona
    {
      public string Carne { get; set; }
        public List<Nota> Notas { get; set; }
        public string Universidad { get; set; }

    }
}