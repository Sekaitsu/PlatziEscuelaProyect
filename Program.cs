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
            /*
             * se puede hacer de dos formas
             * forma 1: 
             * escuela.Nombre = "Platzi Academy";
             * escuela.TipoEscuela = TiposEscuela.Primaria;
            */
            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso()
            {
                Name = "101"
            };
            //arregloCursos[1] = new Curso() { Name = "curso2" };

            //arregloCursos[1] = Name = $"{curso2}";





            var curso1 = new Curso() { Name = "101" };
            var curso2 = new Curso() { Name = "201" };
            var curso3 = new Curso() { Name = "301" };

            //Console.WriteLine(escuela.Nombre);
            //Console.WriteLine(escuela.YearCreacion);
            //Console.WriteLine(escuela.Pais);
            Console.WriteLine(escuela);


            //IMPRIMIR RESULTADOS
            System.Console.WriteLine(" ================== ================== ");
            Console.WriteLine(curso1.Name + "," + curso1.UniqueId); //forma 1 para agregar 
            Console.WriteLine($"{curso2.Name} , {curso2.UniqueId}"); //forma 2 para agregar 
            Console.WriteLine(curso3);
        }

    }
}