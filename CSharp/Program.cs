using System;
using Classe;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
                      
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Akira;
            Pessoas pessoa3 = (Pessoas)3;

            
            Animal animal = new Animal();

            animal.Nome = "rex";
            animal.NomeDono = "pedro";
            animal.Especie = "cachorro";

            Pessoa person = new Pessoa();

            person.Nome = "George";
            person.Idade = 29;
            person.Estado = "PA";
                        

            var classe = new Classe();

            Console.WriteLine(pessoa2);
            
        }
    }
}
