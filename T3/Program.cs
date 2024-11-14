using T3;
bool salir = false;
do
{
    

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("\n");
    Console.WriteLine("*****************************************");
    Console.WriteLine("1- Crear Cita");
    Console.WriteLine("2- Listar Cita");
    Console.WriteLine("3- Modificacion masiva en Universidad");
    Console.WriteLine("4- Salir");
    Console.WriteLine("*****************************************");
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese que opcion desea ingresar primero: ");
    byte opc = byte.Parse(Console.ReadLine());
    Console.ResetColor();
    switch (opc)
    {
        case 1:

            break;
        case 2:
            
            break;
        case 3:
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.Write("Ingrese el texto a buscar en las universidades: ");
            string texto = Console.ReadLine();
            Console.Write("Ingrese el nuevo texto: ");
            Console.ResetColor();
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