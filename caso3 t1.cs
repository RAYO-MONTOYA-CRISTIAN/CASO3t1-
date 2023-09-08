using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso3_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Pedir al usuario el costo del producto C
            Console.WriteLine("Ingrese el costo del producto C: ");
            double costoC = Convert.ToDouble(Console.ReadLine());

        // Pedir al usuario el tiempo de vida útil en meses N
            Console.WriteLine("Ingrese su tiempo de vida útil en meses N: ");
            int tiempoN = Convert.ToInt32(Console.ReadLine());

        // Definir variables
            double depreciacion = TotalDeprec(costoC, tiempoN);
            String calificacion = CalificarDeprec(depreciacion);

            Console.WriteLine("La depreciación del mes " + tiempoN + "  s/ " + depreciacion.ToString("0.00"));
            Console.WriteLine("Su calificación es " + calificacion);
            Console.ReadKey();
        }
        // Calcular la depreciación total
        static double TotalDeprec(double costoC, int tiempoN)
        {
            double valor = costoC * Math.Pow(1 - 1.0 / tiempoN, tiempoN);
            double depreciacion = valor - (100 / tiempoN);
            return depreciacion;
        }
        // Calificar la depreciación
        static string CalificarDeprec(double depreciacion)
        {
            if (depreciacion < 500)
            { return "A"; }
            else if (depreciacion >= 500 && depreciacion < 750)
            { return "B"; }
            else if (depreciacion > 750)
            { return "C"; }
            else
            { return "error"; }
        }
    }
}
