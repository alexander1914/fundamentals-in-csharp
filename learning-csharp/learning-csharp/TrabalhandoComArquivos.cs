using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_csharp
{
    public class TrabalhandoComArquivos
    {
        public void CriarArquivo()
        {
            //StreamWriter: essa é um objeto para trabalhar com arquivos, podemos passar 2 paramêtros
            var escrever = new StreamWriter("Cadastro.txt",true);

            Console.WriteLine("Informe um nome: ");
            var nome = Console.ReadLine();
            //Random é um objeto para criar o ID passando para método Next(um range)
            escrever.WriteLine("ID: " + Random.Shared.Next(1, 100));
            escrever.WriteLine("Nome: " + nome);
            escrever.WriteLine("----------------------------------------------------");
            escrever.Close();
        }

        public void LerArquivo()
        {
            //File: objeto é uma maneira para ler arquivos com método ReadAllText()
            var conteudo = File.ReadAllText("Cadastro.txt");
            Console.WriteLine("File: ");
            Console.WriteLine(conteudo);

            //StreamReader é outra maneira de ler arquivos
            var ler = new StreamReader("Cadastro.txt");
            Console.WriteLine("StreamReader: ");
            while (!ler.EndOfStream)
            {
                var linha = ler.ReadLine();
                Console.WriteLine(linha);                
            }
            
            ler.Close();
        }

        public void ExcluirArquivo()
        {
            
            //Com esses métodos podemos passar o arquivo ou pasta do arquivo
            if (File.Exists("Cadastro.txt"))
            {
                File.Delete("Cadastro.txt");
            }
        }
    }
}
