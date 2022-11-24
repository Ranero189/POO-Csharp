namespace POO.Models
{
    public class Aluno : Pessoa
    {
        public double nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {nome}. Sou um aluno de nota {nota}.");
        }
    }
}