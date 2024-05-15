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

            //int rendimiento;
            //float sueldo;
            //float sueldoPasado;

            Console.WriteLine("Ingrese el nivel de rendimiento según su mes y posterior su sueldo: (1. Bueno 2. Regular 3. Malo):");
            float rendimiento = int.Parse(Console.ReadLine());
            float sueldo = int.Parse(Console.ReadLine());

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
            float sueldoPasado = float.Parse(Console.ReadLine());
            
            if(sueldo > sueldoPasado)
            {
                Console.WriteLine("Su sueldo aumento con respecto al del mes anterior. Felicitaciones!");
            }
            else
            {
                Console.WriteLine("Su sueldo no aumento con respecto al del mes anterior. A seguir!");
            }

            //calcular el costo de un viaje en taxi, considerando la tarifa base y los kilómetros recorridos.
            //Deberás ingresar por teclado la distancia en kilómetros y el tiempo en minutos que duró el viaje.
            //La tarifa base es de 50 pesos y se cobra un adicional de 10 pesos por cada kilómetro recorrido.
            //Si el tiempo del viaje supera los 30 minutos, se agrega un cargo extra de 20 pesos.
            //Calcula y muestra el costo total del viaje, incluyendo todos los cargos adicionales

            Console.WriteLine("Ingrese los km recorridos y tiempo en min que duró el viaje: ");
            int km = int.Parse(Console.ReadLine());
            int minutos = int.Parse(Console.ReadLine());

            int tarifa = 50 + (10 * km);
            if(minutos > 30)
            {
                tarifa += 20; 
            }

            Console.WriteLine("Costo del viaje: $" + tarifa);
        }
    }
}
