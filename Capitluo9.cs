using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    public class Capitulo9
    {
        public struct Productos
        {
            public int idProducto;
            public string nombre;
            public string descripcion;

            public Productos(int id, string n, string d)
            {
                idProducto = id;
                nombre = n;
                descripcion = d;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("ID: {0}, Nombre: {1}, Descripcion: {2}", idProducto, nombre, descripcion);
                return sb.ToString();
            }
        }

        public struct Propietario
        {
            public int idPropietario;
            public string nombre;

            public Propietario(int id, string n)
            {
                idPropietario = id;
                nombre = n;
            }
        }

        public struct Mascota
        {
            public int idMascota;
            public string nombre;
            public string clasificacion;
            public Propietario propietario;

            public Mascota(int id, string n, string clasific, int idProp, string nombreProp)
            {
                idMascota = id;
                nombre = n;
                clasificacion = clasific;
                propietario.idPropietario = idProp;
                propietario.nombre = nombreProp;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("ID: {0}, Nombre: {1}, Clasificacion: {2},\nID de Propietario: {3}, Nombre: {4}", idMascota, nombre, clasificacion, propietario.idPropietario, propietario.nombre);
                return sb.ToString();
            }
        }

        public enum Neumaticos { Verano = 1, Inverno, AllSeasons, Simetrico, Asimetrico, Direccional, Runflat, Tweel, Tubeless, Ecologicos };

        public static void Ejercicio1()
        {
            int id = 0;
            string nombre = "";
            string descripcion = "";
            string valor = "";

            Console.Write("Digite el id del Producto: ");
            valor = Console.ReadLine();
            id = Convert.ToInt32(valor);
            Console.Write("Digite el nombre del Producto: ");
            nombre = Console.ReadLine();
            Console.Write("Digite la descripcion del Producto: ");
            descripcion = Console.ReadLine();

            Productos producto = new Productos(id, nombre, descripcion);
            Console.WriteLine("Informacion del producto: ");
            Console.WriteLine(producto.ToString());
        }

        public static void Ejercicio3()
        {
            int idM = 0, idP = 0;
            string nombreM = "", nombreP = "";
            string clasificacionM = "";
            string valor = "";

            Console.Write("Digite el id de la mascota: ");
            valor = Console.ReadLine();
            idM = Convert.ToInt32(valor);
            Console.Write("Digite el nombre de la mascota: ");
            nombreM = Console.ReadLine();
            Console.Write("Digite la clasificacion de la mascota: ");
            clasificacionM = Console.ReadLine();

            Console.Write("\nDigite el id de del propietario: ");
            valor = Console.ReadLine();
            idP = Convert.ToInt32(valor);
            Console.Write("Digite el nombre del propietario: ");
            nombreP = Console.ReadLine();

            Mascota mascota = new Mascota(idM, nombreM, clasificacionM, idP, nombreP);
            Console.WriteLine("\nInformacion de la mascota: ");
            Console.WriteLine(mascota.ToString());
        }
        
        public static void Ejercicio4()
        {
            Console.WriteLine("Crear una enumeración para los diferentes tipos de neumáticos.\n");
            Console.WriteLine("Neumáticos:\n");

            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.AllSeasons, (int)Neumaticos.AllSeasons);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Asimetrico, (int)Neumaticos.Asimetrico);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Direccional, (int)Neumaticos.Direccional);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Ecologicos, (int)Neumaticos.Ecologicos);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Inverno, (int)Neumaticos.Inverno);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Runflat, (int)Neumaticos.Runflat);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Simetrico, (int)Neumaticos.Simetrico);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Tubeless, (int)Neumaticos.Tubeless);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}", Neumaticos.Tweel, (int)Neumaticos.Tweel);
            Console.WriteLine("Nombre: {0}. Valor en el Enum: {1}\n", Neumaticos.Verano, (int)Neumaticos.Verano);
        }
    }
}
