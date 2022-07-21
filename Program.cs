using System;
using static System.Console; //se añade solo para escribier WriteLine al imprimir
using Event1.Entidades;// se llaman los otros archivos desde el namespace a este archivo

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * se crea una nueva variable llamada escuela, se crea el objeto
             * Se puede poner en el orden que uno desee se puede usar de ambos modos
             */
            var escuela = new clsEscuela("Platzi Academy", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogotá");
            //Forma 3 de arreglo
            escuela.Cursos = new Curso[]
            {
                new Curso(){ Name = "101"},
                new Curso(){ Name = "201"},
                new Curso(){ Name = "301"}
            };
            ImprimirCursosEscuela(escuela);
        }
        private static void ImprimirCursosEscuela(clsEscuela escuela)
        {
            WriteLine("=================================================================");
            WriteLine("                      Cursos de la escuela");
            WriteLine("=================================================================");

            //Forma 1 de imprimir
            //if (escuela != null && escuela.Cursos != null)
            //{
            //    foreach (var curso in escuela.Cursos)
            //    {
            //        WriteLine($"Nombre Curso: {curso.Name}, Id Curso: {curso.UniqueId}");
            //    }
            //}

            //Forma 2 de imprimir 
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre Curso: {curso.Name}, Id Curso: {curso.UniqueId}");
                }
            }
        }
    }
}