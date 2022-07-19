using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event1.Entidades
{
    internal class Curso
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public TiposJornada Jornada { get; set; }


        //cto para construir el constructor
        //guid es numero pero yo lo quiero en string
        //id aleatorios que se genere automaticamente
        public Curso() => UniqueId = Guid.NewGuid().ToString();
    
    }
}
