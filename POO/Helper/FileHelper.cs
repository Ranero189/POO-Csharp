using System.IO;

namespace POO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivos(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories); //*2.text *2* *.txt *

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }
        
        public void DeletarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);

            System.Console.WriteLine(caminho + " foi Deletado");
        }
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
                File.WriteAllText(caminho, conteudo);
        }
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var Stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    Stream.WriteLine(linha);
                }
            }
        } 
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

         public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var Stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    Stream.WriteLine(linha);
                }
            }
        } 
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream(string caminho)
        {
            string? linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminho, string destino)
        {
            File.Move(caminho, destino);
        }
        public void CopiarArquivo(string caminho, string destino, bool sobrescrever)
        {
            File.Copy(caminho, destino, sobrescrever);
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}