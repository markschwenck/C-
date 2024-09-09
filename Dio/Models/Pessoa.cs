using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NameRepresentativeLegal { get; set; }

        public void Apresentation()
        {   
            Console.WriteLine($"olá, meu nome é {Name}, e tenho {Age} anos");
        }

    }
}