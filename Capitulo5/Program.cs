using System;

namespace Capitulo5
{
    class Program
    {
        // Ejercicio #4
        public static void Factorizar(int num)
        {
            int Factor = 1;
            for (int i = 1; i <= num; i++)
            {
                Factor *= i;
            }
            Console.WriteLine($"Factotial de {num} es: {Factor}");
        }
        public static void Verificar(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("El numero que ha escrito es negativo, por favor vuelva a intentar y coloque un numero positivo...");
            }
        }
        // Ejercicio #5
        public static void Letra(int num)
        {
            Console.WriteLine("Digite un numero del 1 al 5");
           num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                default:
                    Console.WriteLine("Opción no valida");
                    break;
                case 1:
                    Console.WriteLine(" Uno");
                    break;
                case 2:
                    Console.WriteLine(" Dos");
                    break;
                case 3:
                    Console.WriteLine(" Tres");
                    break;
                case 4:
                    Console.WriteLine(" Cuatro");
                    break;
                case 5:
                    Console.WriteLine(" Cinco");
                    break;
            }
                
        }
        static void Main(string[] args)
        {
            int num = 0;
            int opcion = 0;
            Console.WriteLine("1- Factorizacion \n2- Numeros en letra");
            Console.WriteLine("Elija una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                default:
                    Console.WriteLine("Opcion no valida, vuelva a intentar...");
                    break;
                case 1:
                    int n;
                    Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
                    do
                    {
                        Console.Write("Por favor Digite un número entero positivo: ");
                        n = int.Parse(Console.ReadLine());
                        Verificar(n);
                    } while (n < 0);
                    Factorizar(n);
                    Console.ReadKey();
                    break;
                case 2:
                    Letra(num);
                    break;
            }
        }
    }
}
