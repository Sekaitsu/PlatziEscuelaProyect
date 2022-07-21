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


            //Forma 1 de arreglo
            //var arregloCursos = new Curso[3]
            //{
            //    new Curso(){ Name = "101" },
            //    new Curso(){ Name = "201" },
            //    new Curso(){ Name = "301" }
            //};

            //Forma 2 de arreglo
            Curso[] arregloCursos =
            {
                new Curso(){ Name = "101" },
                new Curso(){ Name = "201" },
                new Curso(){ Name = "301" }
            };

            WriteLine(escuela);

            //IMPRIMIR RESULTADOS
            WriteLine(" ================== ================== ");
            ImprimirCursos(arregloCursos);
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre: {curso.Name}, Id: {curso.UniqueId}");
            }
        }
    }
}