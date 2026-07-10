using System; //biblioteca de clases del framework .NET

namespace EstudianteUniversidad //definicion del namespace
{
    class Program //clase principal
    {
        static void Main(string[] args) //metodo principal
        {
            Estudiante estudiante = new Estudiante(); //instancia de la clase Estudiante
            
            //llama al metodo CalcularEdad y muestra el resultado
            Console.WriteLine("La edad del estudiante es de: " + estudiante.CalcularEdad() + "años");
            //llama al metodo CalcularHorasTotalesEstudio y muestra el resultado
            Console.WriteLine("las horas de estudio del estudiante son de: " + estudiante.CalcularHorasTotalesEstudio() + "horas");
        }
    }
}