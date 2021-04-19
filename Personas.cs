using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universidades
{
    public class Personas
    {
        string nombre;
        string apellido;
        string direccion;
        DateTime fechanac;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
        public int edad()
        {
            int años = DateTime.Today.Year - fechanac.Year;
            if (DateTime.Today.Month <= fechanac.Month)
            {
                años--;
                if (DateTime.Today.Month == fechanac.Month && DateTime.Today.Day >= fechanac.Day) años++;
            }
            return años;
        }
    }
    public class Alumnos: Personas
    {
        string carne;

        public string Carne { get => carne; set => carne = value; }
    }
    public class Profesores : Personas
    {
        string id;
        string titulo;

        public string Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }
    public class PersonalAd : Personas
    {
        string igss;
        string profesion;
        DateTime iniciolab;
        DateTime finlab;

        public string Igss { get => igss; set => igss = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public DateTime Iniciolab { get => iniciolab; set => iniciolab = value; }
        public DateTime Finlab { get => finlab; set => finlab = value; }
    }
}