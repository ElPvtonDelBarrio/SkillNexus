using System;

Console.WriteLine("=== CALCULADORA BÁSICA ===");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.Write("Elige una opción (1-4): ");

int opcion = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el primer número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double resultado = 0;

switch (opcion)
{
    case 1:
        resultado = num1 + num2;
        Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
        break;
    case 2:
        resultado = num1 - num2;
        Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
        break;
    case 3:
        resultado = num1 * num2;
        Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
        break;
    case 4:
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        else
        {
            resultado = num1 / num2;
            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
        }
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}