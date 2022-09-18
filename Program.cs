using System;

namespace Tarea3
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Capitulo9 a = new Capitulo9(); 
            int opcion1 = 0;
            Console.WriteLine("Elija el Capitulo");
            Console.Write("Presione 1 Capitulo 9/ ");
            Console.Write("Presione 2 Capitulo 10/ ");
            Console.WriteLine("Presione 3 Capitulo 12");
            opcion1 = int.Parse(Console.ReadLine());

            switch(opcion1){
                case 1:
                    int opcion2 = 0;
                    Console.WriteLine("Digite el Numero de Ejercicio:");
                    opcion2 = int.Parse(Console.ReadLine());
                    switch(opcion2){
                        case 1:
                            Console.Clear(); 
                            Capitulo9.Ejercicio1();
                        break;
                        case 2:
                            Console.Clear(); 
                            Capitulo9.Ejercicio3();
                        break;
                        case 3:
                            Console.Clear(); 
                            Capitulo9.Ejercicio4();
                        break;
                        default :
                            Console.WriteLine("Numero de Ejercicio No Valido");
                        break;
                }
                break;
                case 2:
                    int opcion3 = 0;
                    Console.WriteLine("Dijite el numero de Ejercicio:");
                    opcion3 = int.Parse(Console.ReadLine());
                    switch(opcion3){
                        case 1:
                            Capitulo10.Ejercicio2 ejercicio2 = new Capitulo10.Ejercicio2();
                            Console.WriteLine("{0}",ejercicio2.ToString());
                        break; 
                        case 2:
                            Capitulo10.Ejercicio3_4_5 ejercicio3_4_5 = new Capitulo10.Ejercicio3_4_5();
                            Console.WriteLine("{0}", ejercicio3_4_5.ToString());
                        
                        break;
                        default :
                            Console.WriteLine("Numero de Ejercicio No Valido");
                        break;
                    }
                break;
                case 3:
                 Capitulo12.Ejercicio1.Factorial();
                break;
                default :
                Console.WriteLine("Numero de Capitulo No Valido");
                break;
            }
        }
    }
}
