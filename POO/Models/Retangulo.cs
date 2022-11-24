namespace POO.Models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;
        private bool Valido;

        public void DefinirMedidadas(double Comprimento, double Largura)
        {
            if (Comprimento > 0 && Largura > 0)
            {
                this.Comprimento = Comprimento;
                this.Largura = Largura;
                Valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores invalidos");
            }
        }
        public double ObterÁrea()
        {
            if (Valido)
            {
                return Comprimento * Largura;
            }
            else
            {
                System.Console.WriteLine("Preencha com valores validos");
                return 0;
            }
        }

    }
}