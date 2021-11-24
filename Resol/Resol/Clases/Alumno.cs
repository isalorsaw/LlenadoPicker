using System;
using System.Collections.Generic;
using System.Text;

namespace Resol.Clases
{
    public class Alumno
    {
        public string rne { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string ape1 { get; set; }
        public string ape2 { get; set; }

        public string genero { get; set; }

        public string fechanac { get; set; }

        public string gradon { get; set; }

        public string nombrec => $"{nombre1} {nombre2} {ape1} {ape2}";

    }
}
