using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluaciones> Evaluacion { get; set;}   
    }
}