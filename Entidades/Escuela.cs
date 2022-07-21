namespace Event1.Entidades
{
    class clsEscuela
    {
        //CONSTRUCTOR 1 para crear escuelas debe tener unos parametros
        public clsEscuela(string nombre, int year)/*se asigna el nombre y el a�o a las propiedades Nombre , YearCreacion son iguales a los parametros nombre y year*/
        {
            (Nombre, YearCreacion) = (nombre.ToUpper(), year);
            //cuando alguien fuera de la clase quiera asignar un valor el ToUpper es para poner el nombre el mayuscula lo fuerza antes de asignarlo  
        }
        /*CONSTRUCTOR 2*/
        //las comas son separaci�n de objetos dentro de una lista
        public clsEscuela(string nombre, int year, TiposEscuela tipos, string pais = "", string ciudad = "")
        {
            //AISGNACI�N DE DUPLAS
            (Nombre, YearCreacion) = (nombre.ToUpper(), year);
            Pais = pais;
            Ciudad = ciudad;
        }
        //propiedad muestra el nombre para identificar
        //se crean las demas propiedades a usar esta es la manera CORRECTA y mas rapida 
        // se hace un get donde se retona la variable, y se especifica que es una copia del nombre
        public string Nombre { get; set; }
        public int YearCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        //se adiciona otra propiedad donde llama a la entidad Cursos[] la cual ser� usasa en el Program.cs
        public Curso[] Cursos { get; set; }

        //override es sobre escribir ToString y se a�aden las propiedades  y se heredan los atributos
        public override string ToString()
        {
            //el signo $ me permite usar variables en cadenas de texto
            return $"Nombre: {Nombre} \nA�o: {YearCreacion} \nTipo: {TipoEscuela} \nPais: {Pais} \nCiudad: {Ciudad}";
        }
    }
}