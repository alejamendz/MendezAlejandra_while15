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
