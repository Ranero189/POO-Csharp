using POO.interfaces;
namespace POO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        int ICalculadora.Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        int ICalculadora.Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        int ICalculadora.Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}