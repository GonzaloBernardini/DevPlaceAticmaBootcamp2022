using System;
using System.Text.RegularExpressions;

namespace ChallengePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a generar contraseñas\n");
            
            Console.WriteLine("Introduzca una contraseña");
            string passUsuario = Console.ReadLine();
            
            if (Password.EsFuerte(passUsuario))
            {
                Console.WriteLine($"Tu contraseña {passUsuario} es fuerte!");
            }
            else
            {
                Console.WriteLine($"Tu contraseña no es fuerte :(");
            }
            
        }
        
    }
}
