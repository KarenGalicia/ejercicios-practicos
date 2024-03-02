
//4.EJERCICIOS DE PRÁCTICA
using System;

class Program
{
    static long CalcularFactorial(int numero)
    {
        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static double CalcularRaizCuadrada(int numero)
    {
        return Math.Sqrt(numero);
    }

    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Elige sabiamente:");
                Console.WriteLine("1. Calcular el factorial de un número.");
                Console.WriteLine("2. Calcular la raíz cuadrada de un número.");
                Console.WriteLine("3. Realizar operaciones matemáticas.");
                Console.WriteLine("4. Generar tabla de multiplicar.");
                Console.WriteLine("5. Jugar a adivinar un número secreto.");
                Console.WriteLine("6. Salir del programa.");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CalcularFactorialMenu();
                        break;
                    case "2":
                        CalcularRaizCuadradaMenu();
                        break;
                    case "3":
                        OperacionesMatematicas();
                        break;
                    case "4":
                        TablaMultiplicar();
                        break;
                    case "5":
                        JugarAdivinanza();
                        break;
                    case "6":
                        Console.WriteLine("¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.\n");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese un formato válido.\n");
            }
        }
    }

    static void CalcularFactorialMenu()
    {
        Console.Write("Ingrese un número entero positivo: ");
        if (!int.TryParse(Console.ReadLine(), out int numeroFactorial) || numeroFactorial < 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero no negativo.\n");
            return;
        }
        long factorial = CalcularFactorial(numeroFactorial);
        Console.WriteLine($"El factorial de {numeroFactorial} es: {factorial}\n");
    }

    static void CalcularRaizCuadradaMenu()
    {
        Console.Write("Ingrese un número entero positivo: ");
        if (!int.TryParse(Console.ReadLine(), out int numeroRaiz) || numeroRaiz < 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero no negativo.\n");
            return;
        }
        double raizCuadrada = CalcularRaizCuadrada(numeroRaiz);
        Console.WriteLine($"La raíz cuadrada de {numeroRaiz} es: {raizCuadrada}\n");
    }

    static void TablaMultiplicar()
    {
        Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("El número ingresado no es válido.");
            return;
        }

        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    static void OperacionesMatematicas()
    {
        Console.WriteLine("Ingrese el primer número:");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("El primer número ingresado no es válido.");
            return;
        }

        Console.WriteLine("Ingrese el segundo número:");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("El segundo número ingresado no es válido.");
            return;
        }

        Console.WriteLine("Ingrese el operador matemático (+, -, *, /):");
        char operador = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double resultado;
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    return;
                }
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("El operador ingresado no es válido.");
                return;
        }

        Console.WriteLine($"El resultado de {num1} {operador} {num2} es: {resultado}");
    }

    static void JugarAdivinanza()
    {
        Random random = new();
        int numeroSecreto = random.Next(1, 101);
        int intentos = 0;

        Console.WriteLine("¡Bienvenido al juego de adivinar el número secreto!");
        Console.WriteLine("El número secreto está entre 1 y 100.\n");

        while (true)
        {
            Console.Write("Introduce un número: ");

            if (!int.TryParse(Console.ReadLine(), out int numeroUsuario) || numeroUsuario < 1 || numeroUsuario > 100)
            {
                Console.WriteLine("Por favor, introduce un número válido entre 1 y 100.");
                continue;
            }

            intentos++;

            if (numeroUsuario == numeroSecreto)
            {
                Console.WriteLine($"¡Felicidades! Has adivinado el número secreto {numeroSecreto} en {intentos} intentos.");
                break;
            }
            else if (numeroUsuario < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else
            {
                Console.WriteLine("El número secreto es menor.");
            }
        }
    }
}

