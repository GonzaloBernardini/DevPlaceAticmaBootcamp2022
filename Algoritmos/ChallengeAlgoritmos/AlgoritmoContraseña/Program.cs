using System;

namespace AlgoritmoContraseña
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordAttempt2;
            string passwordAttempt;
            int contador = 0;
            Console.WriteLine("**Bienvenido**\nIntroduzca una contraseña");
            passwordAttempt = Console.ReadLine();
            Console.WriteLine("Introduzca otra vez la contraseña");
            while (contador < 3)
            {
                passwordAttempt2 = Console.ReadLine();
                if (passwordAttempt == passwordAttempt2)
                {
                    Console.WriteLine("Felicitaciones recordas tu contraseña!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta, intente de nuevo.. ");
                    contador++;

                }
                if (contador == 3)
                {
                    Console.WriteLine("Oops, tenés que ejercitar más la memoria!");
                }
            }


        }





    }
}
