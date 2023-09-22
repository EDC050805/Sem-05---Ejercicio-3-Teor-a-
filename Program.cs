// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("\tPrograma para hallar el promedio de 'n notas'");
Console.WriteLine("\t·············································\n");
Console.Write("Ingrese el número de notas: ");
int n = int.Parse(Console.ReadLine());
float suma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese la nota " + i + ": ");
    float nota = float.Parse(Console.ReadLine());
    suma += nota;
}
suma /= n;

Console.WriteLine("El promedio es: {0}", suma);
Console.ReadKey();