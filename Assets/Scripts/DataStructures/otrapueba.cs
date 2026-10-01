using System;

namespace SumaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opción 1: Con valores fijos
            int numero1 = 15;
            int numero2 = 25;
            int suma = numero1 + numero2;

            Console.WriteLine("=== PROGRAMA DE SUMA ===");
            Console.WriteLine($"La suma de {numero1} + {numero2} es: {suma}");

            /* 
            // Opción 2: Si prefieres pedir los números por teclado, 
            // descomenta las líneas de abajo borrando los símbolos /* y */

            Console.WriteLine("\nIntroduce el primer número:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int resultado = n1 + n2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
           
        }
    }
}