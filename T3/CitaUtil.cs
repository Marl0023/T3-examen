using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class CitaUtil
    {
        public void Crear(Cita[] citas, ref int indice) {
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
        public static void Listar(Cita[] citas, int cantidadCitas)
        {
            double sumaPrecios = 0;
            Console.WriteLine("Listado de Citas:");
            for (int i = 0; i < cantidadCitas; i++)
            {
                Console.WriteLine(citas[i].ToString());
                sumaPrecios += citas[i].Precio;
            }
            Console.WriteLine($"Suma total de precios: {sumaPrecios:C}\n");
        }
        public static void ModifMasUni(Cita[] citas, int cantidadCitas, string texto, string textoNuevo)
        {
            for (int i = 0; i < cantidadCitas; i++)
            {
                if (citas[i].Estudiante.Universidad.Contains(texto))
                {
                    citas[i].Estudiante.Universidad = citas[i].Estudiante.Universidad.Replace(texto, textoNuevo);
                }
            }
            Console.WriteLine("Modificacion masiva realizada.");
        }



    }
}
