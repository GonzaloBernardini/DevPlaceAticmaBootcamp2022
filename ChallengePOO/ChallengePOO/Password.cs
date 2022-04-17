using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChallengePOO
{
    class Password
    {
        //atributos
        private int longitudContrasenia = 8;

        private string contraseña;

        public int getLongitud()
        {
            return longitudContrasenia;
        }
        public void setLongitud(int longitud)
        {
            this.longitudContrasenia = longitud;
        }
        public string getContraseña()
        {
            return contraseña;
        }
        //Ctor por defecto
        public Password()
        {

        }
        public Password(int longitudUsuario)
        {
            longitudContrasenia = longitudUsuario;
        }
        //Metodo Generar Password
        public static string CrearPassword(int longitud)
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitudCaracteres = caracteres.Length;
            char letra;
            int longitudContrasenia = longitud;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitudCaracteres)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }


        //Metodo es fuerte
        public static bool EsFuerte(string pass)
        {
            Match matchLongitud = Regex.Match(pass, @"^\w{8}\b");
            Match matchNumeros = Regex.Match(pass, @"\d{3}");
            Match matchMayusculas = Regex.Match(pass, @"[A-Z]{2}");
            Match matchMinusculas = Regex.Match(pass, @"[a-z]{1}");

            


            if (!matchLongitud.Success)
            {               
                
                return false;
                
            }else if (!matchNumeros.Success)
            {
                
                return false;
            }
            else if (!matchMayusculas.Success)
            {
               
                return false;
            }
            else if (!matchMinusculas.Success)
            {
                
                return false;
            }
            return true;



        }

        

    }
}
