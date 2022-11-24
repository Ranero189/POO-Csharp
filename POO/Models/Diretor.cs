namespace POO.Models
{
    public class Diretor : Prof
    {
    public override void Apresentar()
    {
    Console.WriteLine($"Olá meu nome é {nome}. Sou um professor, e ganho um salario de R${salario}.");
    }
    }
}