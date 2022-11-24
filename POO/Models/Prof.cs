namespace POO.Models
{
    public class Prof : Pessoa
    {
        public double salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {nome}. Sou um professor, e ganho um salario de R${salario}.");
        }
    }
}