/* Ejercicio 1 - Clase 05 */

string respuesta = "S";
string nombre;

while (respuesta.ToUpper() == "S")
{
    Console.Clear();
    Console.Write("Ingrese su Nombre: ");
    nombre = Console.ReadLine();

    Console.WriteLine($"¡Hola {nombre}!");

    Console.Write("Desea continuar? (S/N): ");
    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no Valida");
}