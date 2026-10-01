using System;

Console.Write("Ingresa el primer número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num2 == 0)
{
    Console.WriteLine("Error: No se puede dividir entre cero.");
}
else
{
    double resultado = num1 / num2;
    Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");
}