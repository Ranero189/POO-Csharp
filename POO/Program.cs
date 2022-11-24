using System;
using System.IO;
using POO.Helper;
using POO.interfaces;
using POO.Models;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // //valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidadas(30, 20);
            // System.Console.WriteLine($"A área do retangulo é {r.ObterÁrea()}");

            // //valores invalidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidadas(0, 0);
            // System.Console.WriteLine($"A área do retangulo é {r2.ObterÁrea()}");

            // Prof p1 = new Prof();
            // p1.nome = "Bob";
            // p1.idade = 20;
            // p1.salario = 859.75;
            // p1.documento = "518.311.868/02";
            // p1.Apresentar();

            // Aluno p2 = new Aluno();
            // p2.nome = "Zé";
            // p2.idade = 32;
            // p2.nota = 10;
            // p2.documento = "62.711.392-8";
            // p2.Apresentar();

            // Calculadora result = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + result.Somar(23, 45));
            // System.Console.WriteLine("Resultado da segunda soma: " + result.Somar(23, 45, 80));

            // Corrente c1 = new Corrente();
            // c1.Creditar(100);
            // c1.ExibirSaldo();

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Multiplicar(50, 20));

            var caminho = "C:\\";

            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");

            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};

            var listaString2 = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

            var destinoArquivo = Path.Combine(caminho, "Pasta teste 1", "arquivo-teste.txt");

            FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivos(caminho);
            // System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.DeletarDiretorio(caminhoPathCombine, true);
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá! teste de escrita de arquivo");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaString2);
            // helper.LerArquivo(caminhoArquivo);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, destinoArquivo);
            // helper.CopiarArquivo(caminhoArquivo, destinoArquivo, true);
            // helper.DeletarArquivo(caminhoArquivo);
        }
    }
}

