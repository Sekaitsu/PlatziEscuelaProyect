
using System;
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

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso()
            {
                Name = "101"
            };

            var curso2 = new Curso()
            {
                Name = "201"
            };
            arregloCursos[1] = curso2;


            var curso3 = new Curso()
            {
                Name = "301"
            };
            arregloCursos[2] = curso3;


            Console.WriteLine(escuela);
            //IMPRIMIR RESULTADOS
            System.Console.WriteLine(" ================== ================== ");
            ImprimirCursos(arregloCursos);
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            for(int contador = 0; contador <= arregloCursos.Length; contador++)
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Name}, Id: {arregloCursos[contador].UniqueId}");
            }

        }
    }
}