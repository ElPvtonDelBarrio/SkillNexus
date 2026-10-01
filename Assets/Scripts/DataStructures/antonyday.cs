using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== RESOLVER SISTEMA DE ECUACIONES (Gauss) ===\n");

        // Pedir tamaño del sistema
        Console.Write("¿Cuántas ecuaciones tiene el sistema? ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Crear la matriz aumentada (n x n+1)
        double[,] matriz = new double[n, n + 1];

        // Pedir los coeficientes
        Console.WriteLine("\nIngresa los coeficientes de cada ecuación:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEcuación {i + 1}:");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"  Coeficiente de x{j + 1}: ");
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write($"  Término independiente (resultado): ");
            matriz[i, n] = Convert.ToDouble(Console.ReadLine());
        }

        // Aplicar eliminación de Gauss
        for (int i = 0; i < n; i++)
        {
            // Buscar el pivote (el mayor valor absoluto en la columna)
            int pivote = i;
            for (int k = i + 1; k < n; k++)
            {
                if (Math.Abs(matriz[k, i]) > Math.Abs(matriz[pivote, i]))
                    pivote = k;
            }

            // Intercambiar filas si es necesario
            if (pivote != i)
            {
                for (int j = 0; j <= n; j++)
                {
                    double temp = matriz[i, j];
                    matriz[i, j] = matriz[pivote, j];
                    matriz[pivote, j] = temp;
                }
            }

            // Verificar si el pivote es cero (sistema sin solución única)
            if (Math.Abs(matriz[i, i]) < 1e-10)
            {
                Console.WriteLine("\nEl sistema no tiene solución única.");
                return;
            }

            // Hacer el pivote igual a 1
            double divisor = matriz[i, i];
            for (int j = i; j <= n; j++)
            {
                matriz[i, j] /= divisor;
            }

            // Hacer ceros en la columna del pivote (eliminación)
            for (int k = 0; k < n; k++)
            {
                if (k != i)
                {
                    double factor = matriz[k, i];
                    for (int j = i; j <= n; j++)
                    {
                        matriz[k, j] -= factor * matriz[i, j];
                    }
                }
            }
        }

        // Mostrar resultados
        Console.WriteLine("\n=== SOLUCIÓN DEL SISTEMA ===");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"x{i + 1} = {matriz[i, n]:F4}");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}