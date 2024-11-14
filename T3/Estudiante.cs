using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T3
{
    public class Estudiante
    {
        public int Codigo {  get; set; }
        public string Nombre { get; set; }
        public string Universidad {  get; set; }
        
        public Estudiante(int codigo, string nombre, string universidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Universidad = universidad;
        }
        public override string? ToString()
        {
            return $"El estudiante {Nombre}, con el cofigo {Codigo} de la universidad {Universidad}.";
        }
    }
}
