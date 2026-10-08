using System;

class Program
{
    static void Main()
    {
        // 1. PRIMERO DECLARAMOS LAS VARIABLES 
        double num1;
        double num2;
        double suma, resta, multiplicacion, division;
        {
            // 2. Pedimos los datos
            Console.Write("Ingresa el primer número: ");
            num1 = double.Parse(Console.ReadLine()!);
        }
        {
            Console.Write("Ingresa el segundo número: ");
            num2 = double.Parse(Console.ReadLine()!);
        }
        // 3. OPERAMOS CON ELLOS
        suma = num1 + num2;
        resta = num1 - num2;
        multiplicacion = num1 * num2;
        division = num1 / num2;

        // 4. MOSTRAMOS RESULTADOS

        Console.WriteLine($"Suma: {suma}");

        Console.WriteLine($"Resta: {resta}");

        Console.WriteLine($"Multiplicación: {multiplicacion}");

        Console.WriteLine($"División: {division}");
    }
}

