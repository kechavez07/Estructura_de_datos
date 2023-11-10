namespace Taller1
{
    class Ejerccio6
    {

        public int CalcularMCD(int m, int n)
        {
            if (n == 0)
            {
                return m;
            }
            else return CalcularMCD(n, m % n);

        }

        public void Ejecutar()
        {
            Console.Write("Ingresar el valor de M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Ingresar el valor de N: ");
            int n = int.Parse(Console.ReadLine());

            if (m < 0)
            {
                int aux = m;
                m = n;
                n = aux;
            }

            int resultado = CalcularMCD(m, n);

            Console.WriteLine($"El minimo comun multiplo de {m} y {n} es : {resultado}");
            Console.ReadKey();
        }
    }


    class Ejerccio4
    {
        //Escribir una función recursiva que devuelva la suma de los primeros N enteros

        public int Suma(int num)
        {
            int aux = 0;
            if (num > 0) {
                aux = num + Suma(num - 1);
            }
            return aux;
        }

        public void Ejecutar()
        {
            Console.Write("Ingresar el valor : ");
            int num = int.Parse(Console.ReadLine());
            
            int respuesta = Suma(num);

            Console.WriteLine($"la sumatoria de los primeros numeros de {num} : {respuesta}");
            Console.ReadKey();

        } 

    }
    class Ejerccio5
    {
        //Escribir un programa que encuentre la suma de los enteros positivos pares desde N hasta 2.
        //Chequear que si N es impar se imprima un mensaje de error.

        public int Suma(int num)
        {
            int aux = 0;

            if (num > 0)
            {
                aux = num + Suma(num - 2);
            }
            return aux;
        }
        public bool Par(int num)
        {
            return num % 2 == 0;
        }
        public void Ejecutar()
        {
            Console.Write("Ingresar el valor de N: ");
            int m = int.Parse(Console.ReadLine());
            int resultado = 0;
            if (Par(m))
            {
                resultado = Suma(m);
            }
            else
            {
                Console.Write("ERRO  vuelva a ingresar ");
                Ejecutar();
            }

            Console.WriteLine($"La sumatoria de {m} hasta 2 es : {resultado}");
            Console.ReadKey();
        }
    }

    internal class Program
    {   
            static void Main(string[] args)
        {
            Ejerccio6 uno = new Ejerccio6(); 
            Ejerccio4 dos = new Ejerccio4();
            Ejerccio5 tres = new Ejerccio5();


            //uno.Ejecutar();
            //dos.Ejecutar();
            tres.Ejecutar();

        }
    }
}