using System;

namespace AlgoritmoPrimos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (EsPrimo(numero))
            {
                //Es primo
                Console.WriteLine("Es primo");
            }
            else
            {
                //No es primo
                Console.WriteLine("No es primo");
            }

        }
        static bool EsPrimo(int numero)
        {
            //el 1 es algo especial por lo cual comenzamos por el numero real 2
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
