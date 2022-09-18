namespace Tarea3.Capitulo10
{
    public class Ejercicio2
    {
        private int Id { get; set; }
        private string PrimerNombre { get; set; }
        private string SegundoNombre { get; set; }
        private string PrimerApellido { get; set; }
        private string SegundoApellido { get; set; }
        private byte Edad { get; set; }
        private string Grado { get; set; }
        private string Aula { get; set; }
        private string Seccion { get; set; }

        public Ejercicio2()
        {
            Id = 1;
            PrimerNombre = "Frank";
            SegundoNombre = "Yeuri";
            PrimerApellido = "Goris";
            SegundoApellido = "Nunez";
            Edad = 22;
            Grado = "Decimo Cuatrimestre";
            Aula = "Lab Sistemas B";
            Seccion = "Seccion Unica";
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Id: " + Id.ToString() + "\nNombres y Apellidos: " + PrimerNombre.ToString() + " " + SegundoNombre.ToString() + " ";
            mensaje += PrimerApellido.ToString() + " " + SegundoApellido.ToString();
            mensaje += "\nEdad: " + Edad.ToString() + "\nGrado: " + Grado.ToString() + "\nAlula: " + Aula.ToString() + "\nSeccion: " + Seccion.ToString(); 
            return mensaje;
        }
    }
}