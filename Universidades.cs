using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universidades
{
    public class Estudiante
    {
        string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
    }
    public class Universidades
    {
        string universidad;

        List<Estudiante> estudiantes = new List<Estudiante>();

        public string Universidad { get => universidad; set => universidad = value; }
        public List<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }


        public Universidades()
        {
            Estudiantes = new List<Estudiante>();
        }
    }
}