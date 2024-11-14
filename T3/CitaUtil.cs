using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class CitaUtil
    {
        public void CrearCita(Cita[] cita, ref int indice) {
            Console.WriteLine("Llene los siguientes datos a continuacion.");
            Console.Write("Numero de cita: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Codigo del estudiante: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la universidad del estudiante: ");
            string universidad = Console.ReadLine();
            Console.Write("Ingrese la enfermedad: ");
            string enfermedad = Console.ReadLine();
            Console.Write("Precio del tratamiento: ");
            double precio = double.Parse(Console.ReadLine());
            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);
            citas[indice] = new Cita(numero, estudiante, enfermedad, precio);
            indice++;
        }

    }
}
