using System; //biblioteca de clases del framework .NET

namespace EstudianteUniversidad //definicion del namespace
{
    class Program //clase principal
    {
        static void Main(string[] args) //metodo principal
        {
            Estudiante estudiante = new Estudiante(); //instancia de la clase Estudiante
            estudiante.MostrarInformacionEstudiante();
        }
    }
}