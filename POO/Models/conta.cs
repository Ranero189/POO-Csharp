namespace POO.Models
{
    public abstract class Conta
    {
        protected double Saldo {set; get;}

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é: {Saldo}");
        }
    }
}