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

            Console.WriteLine("Ingresa la carrera a la que pertenece el estudiante:");
            carrera = Console.ReadLine();

            Console.WriteLine("Ingresa el promedio general del estudiante:");
            promedioGeneral = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el numero de materias inscritas por el estudiante:");
            numeroMateriasInscritas = Convert.ToInt32(Console.ReadLine());
        }
        public int CalcularEdad() //metodo para calcular la edad del estudiante
        {
            return DateTime.Now.Year - fechaNacimiento;
        }
        public int CalcularHorasTotalesEstudio() //metodo para calcular el total de horas cursadas por el estudiante
        {
            return numeroMateriasInscritas * 4; //cada materia tiene 4 horas
        }
        public string NombreReorganizado() //metodo para reorganizar el nombre del estudiante
        {
            string[] partesNombre = nombreCompleto.Split(' ');

            string nombre = partesNombre[0];
            string apellidoPaterno = partesNombre[1];
            string apellidoMaterno = partesNombre[2];

            return apellidoPaterno + " " + apellidoMaterno + " " + nombre;
        }

        public void MostrarInformacionEstudiante() //metodo para mostrar la informacion del estudiante
        {
            Console.WriteLine("Nombre completo: " + NombreReorganizado());
            Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento);
            Console.WriteLine("Carrera: " + carrera);
            Console.WriteLine("Promedio general: " + promedioGeneral);
            Console.WriteLine("Materias inscritas: " + numeroMateriasInscritas);
            Console.WriteLine("Edad del estudiante: " + CalcularEdad() + " años");
            Console.WriteLine("Horas de estudio semanales: " + CalcularHorasTotalesEstudio() + " horas");
        }
    }
}