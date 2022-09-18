using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Capitulo12
{
    public class Ejercicio1
    {
        public static void Factorial()
        {
            int n = 0;
            int numero = 0;
            int factorial = 1; 
            string valor ="";
            Console.Write("Dame el número al que se le saca el factorial: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);
            for (n = numero; n >= 1; n--)
                factorial *= n;
            Console.WriteLine("El factorial de {0} es {1}",numero, factorial);
        }
    }
}
