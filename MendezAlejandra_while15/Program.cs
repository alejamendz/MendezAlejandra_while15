// See https://aka.ms/new-console-template for more information
Console.WriteLine("----MENÚ----");

int opcion = 0;

while (opcion != 3)
{
    Console.WriteLine("1. Saludar Usuario");
    Console.WriteLine("2. Mensaje al usuario");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Opcion: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola usuario");
            break;

        case 2:
            Console.WriteLine("Hola de nuevo =)");
            break;

        case 3:
            Console.WriteLine("Saliendo");
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
    Console.WriteLine();
}

