using T3;

Cita[] citas = new Cita[0];
int cantidadCitas = 0;
bool salir = false;
do
{
    Console.WriteLine("\n");
    Console.WriteLine("*****************************************");
    Console.WriteLine("Ingrese que opcion desea ingresar primero: ");
    Console.WriteLine("1- Crear Cita");
    Console.WriteLine("2- Listar Cita");
    Console.WriteLine("3- Modificacion masiva en Universidad");
    Console.WriteLine("4- Salir");
    Console.WriteLine("*****************************************");
    Console.WriteLine("\n");
    byte opc = byte.Parse(Console.ReadLine());
    switch (opc) {
        case 1:
            Array.Resize(ref citas,citas.Length+1);
            CitaUtil.Crear(citas, ref cantidadCitas);
            break;
        case 2:
            CitaUtil.Listar(citas, cantidadCitas);
            break;
        case 3:
            Console.Write("Ingrese el texto a buscar en las universidades: ");
            string texto = Console.ReadLine();
            Console.Write("Ingrese el nuevo texto: ");
            string textoNuevo = Console.ReadLine();
            CitaUtil.ModifMasUni(citas, cantidadCitas, texto, textoNuevo);
            break;
        case 4:
            salir = true;
            break;
        default:
            Console.WriteLine("Valor no encontrado, vuelva intentarlo");
            break;
    }
} while (!salir);
Console.WriteLine("Cerrando Programa...");