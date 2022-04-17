using System;

namespace AlgoritmoRepeatedNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, suma = 0, numMayor = 0, numMenor = 0;
            do
            {
                Console.WriteLine("Introduce un numero \nSi quieres salir del programa escribe -1 ");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
                if (num==0)
                {
                    numMenor = num;
                }
                else if (num<numMenor)
                {
                    numMenor = num;
                }
                if (num==0)
                {
                    numMayor = num;
                }
                else if (num>numMayor)
                {
                    numMayor = num;
                }
                
            } while (num != -1);
            Console.WriteLine($"La suma de todos los numeros introducidos es: {suma}");
            Console.WriteLine($"El numero ingresado mas alto es: {numMayor}");
            Console.WriteLine($"El numero ingresado mas bajo es: {numMenor}");
        }
    }
}
