using System;
namespace LibroCalificaciones_2
{
    public class LibroPruebacalificacion
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            MilibroCalificaciones myLibro = new MilibroCalificaciones();
            //pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Escriba el nombre del curso:");
            string nombreDelCurso = Console.ReadLine(); //lee una linea de texto
            Console.WriteLine();


            myLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}
