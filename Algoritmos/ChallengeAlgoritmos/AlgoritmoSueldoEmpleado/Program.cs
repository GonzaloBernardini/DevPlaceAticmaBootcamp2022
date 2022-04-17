using System;


namespace AlgoritmoSueldoEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Nombre del Empleado");
            string nameEmpleado = Console.ReadLine();
            Console.WriteLine("Ingrese el valor hora del empleado");
            decimal valorHoraEmpleado = Convert.ToDecimal(Console.ReadLine());            
            Console.WriteLine("Ingrese la Antiguedad '(en años)' del Empleado");
            int antiguedadEmpleado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese horas trabajadas del Empleado");
            decimal horasTrabajadas = Convert.ToDecimal(Console.ReadLine());
            decimal totalSueldo = decimal.Round(horasTrabajadas * valorHoraEmpleado,2);
            if (antiguedadEmpleado >10)
            {
                totalSueldo += decimal.Round(antiguedadEmpleado * 30,2); 
            }
            Console.WriteLine($"Nombre : {nameEmpleado}");
            Console.WriteLine($"Antiguedad : {antiguedadEmpleado}");
            Console.WriteLine($"El Sueldo Total del empleado es de: $ {totalSueldo}");

        }
    }
}
