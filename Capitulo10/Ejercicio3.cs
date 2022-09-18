using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Capitulo10
{
    public class Ejercicio3_4_5
    {
        private Triangulo triangulo;
        private Cuadrado cuadrado;
        private Pentagono pentagono;
        private Exagono exagono;

        public Ejercicio3_4_5()
        {
            triangulo = new Triangulo();
            cuadrado = new Cuadrado();
            pentagono = new Pentagono();
            exagono = new Exagono();
        }

        public Ejercicio3_4_5(Triangulo triangulo)
        {
            triangulo = new Triangulo();
        }

        public Ejercicio3_4_5(Cuadrado cuadrado)
        {
            cuadrado = new Cuadrado();
        }

        public Ejercicio3_4_5(Pentagono pentagono)
        {
            pentagono = new Pentagono();
        }

        public Ejercicio3_4_5(Exagono exagono)
        {
            exagono = new Exagono();
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Triangulo: " + triangulo.CantidadDeLados.ToString() + "\nCuadrado: " + cuadrado.CantidadDeLados.ToString();
            mensaje += "\nPentagono: " + pentagono.CantidadDeLados.ToString() + "\nExagono: " + exagono.CantidadDeLados.ToString();
            return mensaje;
        }

        public class Triangulo
        {
            private int cantidadDeLados;
            public int CantidadDeLados
            {
                get
                {
                    return cantidadDeLados;
                }

                set
                {
                    if (value <= 0)
                        cantidadDeLados = 1;

                }
            }

            public Triangulo()
            {
                cantidadDeLados = 3;
            }
        }

        public class Cuadrado
        {
            private int cantidadDeLados;
            public int CantidadDeLados
            {
                get
                {
                    return cantidadDeLados;
                }

                set
                {
                    if (value <= 0)
                        cantidadDeLados = 1;

                }
            }
            public Cuadrado()
            {
                cantidadDeLados = 4;
            }
        }


        public class Pentagono
        {
            private int cantidadDeLados;
            public int CantidadDeLados
            {
                get
                {
                    return cantidadDeLados;
                }

                set
                {
                    if (value <= 0)
                        cantidadDeLados = 1;

                }
            }
            public Pentagono()
            {
                cantidadDeLados = 5;
            }
        }

        public class Exagono
        {
            private int cantidadDeLados;
            public int CantidadDeLados
            {
                get
                {
                    return cantidadDeLados;
                }

                set
                {
                    if (value <= 0)
                        cantidadDeLados = 1;

                }
            }
            public Exagono()
            {
                cantidadDeLados = 6;
            }
        }
    }
}
