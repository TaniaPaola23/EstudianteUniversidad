using System; //biblioteca de clases del framework .NET

namespace EstudianteUniversidad //definicion del namespace
{
    class Estudiante //clase 
    {     //atributos
        string nombreCompleto;
        int fechaNacimiento;
        string carrera;
        double promedioGeneral;
        int numeroMateriasInscritas;

       public Estudiante() //constructor
        {
            Console.WriteLine("Ingresa el nombre completo del estudiante:");
            nombreCompleto = Console.ReadLine();

            Console.WriteLine("Ingresa la fecha (año) de nacimiento del estudiante:");
            fechaNacimiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la carrera a la que perenece el estudiante:");
            carrera = Console.ReadLine();

            Console.WriteLine("Ingresa el promedio general del estudiante:");
            promedioGeneral = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de materias inscritas por el estudiante:");
            numeroMateriasInscritas = Convert.ToInt32(Console.ReadLine());
        }
    }
}