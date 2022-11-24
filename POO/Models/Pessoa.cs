using System;

namespace POO.Models
{
    public class Pessoa
    {
        public string? nome { get; set; }

        public int idade { get; set; }

        public string? documento { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {nome} e tenho {idade} anos");
        }
    }
}