using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacro1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rendimiento;
            float sueldo;
            float sueldoPasado;

            Console.WriteLine("Ingrese el nivel de rendimiento según su mes y posterior su sueldo: (1. Bueno 2. Regular 3. Malo):");
            rendimiento = int.Parse(Console.ReadLine());
            sueldo = int.Parse(Console.ReadLine());

            if(rendimiento == 1) 
            {
                sueldo = sueldo * 1.1f;
            } else if(rendimiento == 2)
            {
                sueldo = sueldo * 1.05f;
            }
            else
            {
                Console.WriteLine("Debido a tu nivel de rendimiento tu sueldo no aumenta.");
            }

            Console.WriteLine("Sueldo a cobrar: $" + sueldo);
            Console.WriteLine("Ingrese su sueldo del mes pasado: ");
            sueldoPasado = float.Parse(Console.ReadLine());
            
            if(sueldo > sueldoPasado)
            {
                Console.WriteLine("Su sueldo aumento con respecto al del mes anterior. Felicitaciones!");
            }
            else
            {
                Console.WriteLine("Su sueldo no aumento con respecto al del mes anterior. A seguir!");
            }
        }
    }
}
