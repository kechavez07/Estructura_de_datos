using System;

namespace RecursividadEstructura
{
    internal class Program
    {
        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nSelecciona una opción:");
            Console.WriteLine("1. Invertir arreglo (Ejercicio 10)");
            Console.WriteLine("2. Función recursiva f (Ejercicio 11)");
            Console.WriteLine("3. Verificar palíndromo (Ejercicio 12)");
            Console.WriteLine("4. Descomposiciones como suma de números menores (Ejercicio 13)");
            Console.WriteLine("5. Salir");

                if (int.TryParse(Console.ReadLine(), out int opcion))
            {

                    switch (opcion)
            {
                case 1:
                    EjecutarInvertirArreglo();
                    break;
                case 2:
                    EjecutarFuncionRecursivaF();
                    break;
                case 3:
                    EjecutarVerificarPalindromo();
                    break;
                case 4:
                    EjecutarDescomposiciones();
                    break;
                case 5:
                    salir= true;
                    break;  
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            }
        }


//Ejercicio 10
        static void EjecutarInvertirArreglo()
        {
            Console.WriteLine("Ingrese los elementos del arreglo separados por espacios:");
            string[] elementos = Console.ReadLine().Split(' ');

            int[] arreglo = new int[elementos.Length];
            for (int i = 0; i < elementos.Length; i++)
            {
                arreglo[i] = int.Parse(elementos[i]);
            }

            Console.Write("Arreglo original: ");
            ImprimirArreglo(arreglo);

            InvertirArreglo(arreglo, 0, arreglo.Length - 1);

            Console.Write("\nArreglo invertido: ");
            ImprimirArreglo(arreglo);
        }

        static void InvertirArreglo(int[] arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                
                int temp = arr[inicio];
                arr[inicio] = arr[fin];
                arr[fin] = temp;

                
                InvertirArreglo(arr, inicio + 1, fin - 1);
            }
        }

        static void ImprimirArreglo(int[] arr)
        {
            foreach (var elemento in arr)
            {
                Console.Write(elemento + " ");
            }
        }


//Ejercicio 11
        static void EjecutarFuncionRecursivaF()
        {
            Console.WriteLine("Ingresa el valor de x:");
            int resultado = f(int.Parse(Console.ReadLine()));
            Console.WriteLine("Resultado: " + resultado);
        }

        static int f(int x)
        {
            if (x > 100)
            {
                return (x - 10);
            }
            else
            {
                return f(f(x + 11));
            }
        }


//Ejercicio 12
        static void EjecutarVerificarPalindromo()
        {
            Console.WriteLine("Ingresa una palabra:");
            string palabra = Console.ReadLine();

            if (EsPalindromo(palabra))
                Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
            else
                Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
        }

        static bool EsPalindromo(string str)
        {
            string cadenaLimpia = LimpiarCadena(str.ToLower());
            return EsPalindromoRecursivo(cadenaLimpia, 0, cadenaLimpia.Length - 1);
        }

        static bool EsPalindromoRecursivo(string str, int inicio, int fin)
        {
            if (inicio >= fin)
                return true;

            if (str[inicio] == str[fin])
            {
                return EsPalindromoRecursivo(str, inicio + 1, fin - 1);
            }
            else
            {
                return false;
            }
        }

        static string LimpiarCadena(string str)
        {
            return str.Replace(" ", "");
        }


//Ejercicio 13
        static void EjecutarDescomposiciones()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Descomposiciones de {numero} como suma de números menores que él:");
            ImprimirDescomposiciones(numero, "");
        }

        static void ImprimirDescomposiciones(int n, string descomposicionActual)
        {
            if (n == 0)
            {
                Console.WriteLine(descomposicionActual);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                ImprimirDescomposiciones(n - i, $"{descomposicionActual} + {i}");
            }
        }
    }
}