using System;

namespace AlgoritmoNumRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random aleatorio = new Random();           
            int numeroX;
            numeroX = aleatorio.Next(1, 1001);
            int numeroUsuario;
            
            do
            {
                
                Console.WriteLine("Introduzca el numero a comparar");
                numeroUsuario = Convert.ToInt32(Console.ReadLine());
                if (numeroUsuario == numeroX)
                {
                    break;
                }
                else if(numeroX > numeroUsuario)
                {
                    Console.WriteLine("El numero es mayor");
                }
                else
                {
                    Console.WriteLine("El numero es menor");
                }

            } while (numeroX != numeroUsuario);
            
        }
    }
}
