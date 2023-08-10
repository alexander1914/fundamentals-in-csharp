using System;
using System.Collections.Generic;
using System.Text;

namespace learning_csharp
{
    class TrabalhandoStrings
    {
        #region ToLower()
        // é método utilizado para converter letras minúsculas             

        public void ConverterParaLetrasMinusculas()
        {
            Console.Write("Por gentileza digitar alguma coisa: ");
            var linha = Console.ReadLine();
            Console.WriteLine($"Resposta: {linha.ToLower()}");
        }

        #endregion

        #region ToUpper()
        // é método utilizado para converter letras maiusculas

        public void ConverterParaLetrasMaiusculas() 
        {
            Console.Write("Por gentileza digitar alguma coisa: ");
            var linha = Console.ReadLine();
            Console.WriteLine($"Resposta: {linha.ToUpper()}");
        }

        #endregion

        #region Substrings()
        // é método utilizado para acessar os caracteres de uma string a partir das posição incial e final (0, 6) 

        public void Substrings()
        {
            Console.Write("Por gentileza digitar alguma coisa: ");
            var linha = Console.ReadLine();
            Console.WriteLine($"Resposta: {linha.Substring(0, 9)}");
        }

        #endregion

        #region Range
        // é método para acessar a string por range

        public void Range()
        {
            string nomeArquivo = "2023_08_09_licao10.txt";
            
            string ano = nomeArquivo[..4];
            Console.WriteLine(ano);

            string extensao = nomeArquivo[^3..];
            Console.WriteLine(extensao);

            string nome = nomeArquivo[11..^4];
            Console.WriteLine(nome);
        }

        #endregion

        #region Contains()
        // é metódo para verificar(validar) se existe algum valor na cadeia de caracteres

        public void Contains()
        {
            string nomeCompleto = "Alexander Albuquerque Oliveira";

            if (nomeCompleto.Contains("Alexander")) 
            {
                Console.WriteLine("Palavra encontrada");
            }
            else
            {
                Console.WriteLine("Essa palavra não existe !!!");
            }
            //Console.WriteLine("Contem nome: " + nomeCompleto.Contains("Alexander"));
        }

        #endregion

        #region Trim, TrimStart, TrimEnd()
        // esses metódos são para remover caracteres de uma string
        // OBS: se usar apenas o trim() sem paremetro ele vai remover os espaços

        public void MetodosTrims()
        {
            string nome = "****Alexander Oliveira****";
            Console.WriteLine("TRIM TOTAL: " + nome.Trim('*'));
            Console.WriteLine("TRIM INICIAL: " + nome.TrimStart('*'));
            Console.WriteLine("TRIM FINAL: " + nome.TrimEnd('*'));
        }

        #endregion

        #region StartsWith EndsWith()
        // StartsWith: metódo para validar se inicia com uma determina palavra da string
        // EndsWith:   metódo para validar se finaliza com uma determina palavra da string

        public void StartWithEndWith()
        {
            string teste = "Curso Csharp";
            Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
            Console.WriteLine("FINAL: " + teste.EndsWith("Csharp02"));
        }

        #endregion

        #region Replace()
        // é metódo utilizado para substituir um valor de uma string
        //OBS: é necessário passar o valor atual da string e depois o novo valor para string

        public void Replace()
        {
            string nomeCompleto = "Alexander Pereira Oliveira";

            Console.WriteLine("Antes: " + nomeCompleto);

            Console.WriteLine("Depois de aplicar o replace: " +
                    nomeCompleto.Replace("Pereira", "Albuquerque"));
        }

        #endregion

        #region Length
        // é uma propriedade para mostrar a quantidade de caracter dentro da string

        public void Length()
        {
            string teste = Console.ReadLine();
            Console.WriteLine(teste);
            Console.WriteLine($"Total de caracteres é: {teste.Length}");
        }

        #endregion
    }
}
