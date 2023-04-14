using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting my code");

            #region Variáveis

            /*int year = 32;
            string name = "alexander albuquerque oliveira";
            //m sempre no final de um decimal
            decimal salary = 20.000m;
            //f sempre no final de um floal
            float discont = 700.65f;
            double taxe = 5.0;
            char flag = 'a';
            bool active = true;

            #region const: uma const é um valor que não pode ser alterado
            const string description = "this course about fundamentls of c#";
            #endregion


            console.writeline($"my year is : {year}");
            console.writeline($"my name is : {name}");
            console.writeline($"my salary is : {salary}");
            console.writeline($"my taxe is : {taxe}");
            console.writeline($"my discont is : {discont}");
            console.writeline($"my flag is : {flag}");
            console.writeline($"am i active? : {active}");

            Console.WriteLine(description);*/

            #endregion

            #region Operadores Artiméticos

            /*var numero1 = 10;
            var numero2 = 10;

            var soma = numero1 + numero2;

            Console.WriteLine(soma);

            int subtracao = numero1 - numero2;
            Console.WriteLine($"O Resultado é: {subtracao}");

            int multiplicacao = (numero1 * numero2) * 20;
            Console.WriteLine($"O Resultado é: {multiplicacao}");

            int divisao = numero1 / numero2;
            Console.WriteLine($"O Resultado é: {divisao}");*/

            #endregion

            #region Operadores Relacionais

            /*int numero1 = 1;
            int numero2 = 2;

            bool igual = numero1 == numero2;
            Console.WriteLine($"O Resultado é: {igual}");

            bool maior = numero1 > numero2;
            Console.WriteLine($"O Resultado é: {maior}");

            bool menor = numero1 < numero2;
            Console.WriteLine($"O Resultado é: {menor}");

            bool menorOuIgual = numero1 <= numero2;
            Console.WriteLine($"O Resultado é: {menorOuIgual}");

            bool maiorOuIgual = numero1 >= numero2;
            Console.WriteLine($"O Resultado é: {maiorOuIgual}");

            bool diferente = numero1 != numero2;
            Console.WriteLine($"O Resultado é: {diferente}");*/

            #endregion

            #region Operadores Lógicos (&&, ||, !)

            /*int numero1 = 10;
            int numero2 = 20;

            bool valido = numero2 > numero1 && 8 > 5;
            Console.WriteLine($"O Resultado é: {valido}");

            bool valido2 = numero2 > numero1 || 4 > 5;
            Console.WriteLine($"O Resultado é: {valido2}");

            bool valido3 = !(numero2 > 10);
            Console.WriteLine($"O Resultado é: {valido3}");*/

            #endregion

            #region Operador ternário

            /*bool ativo = true;
            string status = ativo ? "Cadastro Ativo" : "Cadastro Inativo";
            Console.WriteLine($"O Resultado é: {status}");*/

            #endregion

            #region Funções in C#

            /*var nomeCompleto = NomeCompleto();
            
            string NomeCompleto()
            {
                string primeiroNome = "Alexander";
                string segundoNome = "Vargas";
                return primeiroNome + " " + segundoNome;
            }

            var mediaDoAluno = Media();
            
            double Media()
            {
                double nota1 = 7.5;
                double nota2 = 6.5;

                return (nota1 + nota2) / 2;
            }

            QualEMeuNome();
            // void:  é uma função sem return o retorno
            void QualEMeuNome()
            {
                NomeCompleto();
            }

            int soma = SomaDeValores(1000, 10000);
            int SomaDeValores(int a, int b)
            {
                return a + b;
            }

            var nomeEIdade = NomeEIdade("Alexander Vargas Oliveira", 32);
            string NomeEIdade(string nome, int idade)
            {              
                return "Meu nome é: " + nome + " e tenho " + idade + " anos";  
            }
            
            Console.WriteLine($"Executando minha função 1: {nomeCompleto}");
            Console.WriteLine($"Executando minha função 2: {mediaDoAluno}");
            Console.WriteLine($"Executando minha função com paramêtro 3: {soma}");
            Console.WriteLine($"Executando minha função com paramêtro 4: {nomeEIdade}");*/

            #endregion

            #region ArrayList e ArrayList Tipado

            /*ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Alexander Vargas Oliveira");
            arrayList.Add("B2");
            arrayList.Add("Software Engineer");

            // RemoveAt(): essa função remove um item da sua lista pelo indice
            arrayList.RemoveAt(0);
            //Clear(): essa função remove todos os itens da sua lista
            //arrayList.Clear();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Minha ArrayList: {arrayList}");

            var arrayTipado = new int[3]
            {
                1, 2, 3,
            };

            arrayTipado[2] = 99;

            //Array.Resize(): é uma função do arraylist para aumentar o tamanho do array
            Array.Resize(ref arrayTipado, 5);

            arrayTipado[3] = 20;
            arrayTipado[4] = 21;
            arrayTipado[4] = 23;

            foreach (var item in arrayTipado) 
            {
                Console.WriteLine($"Items do ArrayList Tipado: {item}");
            }
            Console.WriteLine($"Meu ArrayList Tipado: {arrayTipado}");*/

            #endregion

            #region Treinando o LinkedList 

            LinkedList<Int32> myList = new LinkedList<Int32>();

            Processando(1);
            Processando(2);
            Processando(3);

            RetornaMinhaLista();
            
            int Processando(int number)
            {
                try
                {
                    if (number != null)
                    {
                        myList.AddFirst(number);
                    }
                }
                catch (Exception e) { 
                    e.GetBaseException().ToString();
                }

                return number;
            }

            LinkedList<Int32> RetornaMinhaLista()
            {
                return myList;
            }

            #endregion

            #region Lista Génerica
            //List<>: é uma lista génerica que a microsoft recomenda nós usarmos

            /*var lista = new List<string>(10);
            lista.Add("Oliveira");
            lista.Add("Maciel");
            lista.Add("Vargas");
            lista.Add("Silva");

            var sobrenome = lista[0];
            Console.WriteLine($"O Sobrenome é: {sobrenome}");*/

            #endregion

            #region Dictionary
            //Dictionary: trabalha com chave e o valor

            /*Dictionary<int, string> diacionario = new Dictionary<int, string>();
            diacionario.Add(1, ".NET");
            diacionario.Add(2, "Microsoft");

            string texto = diacionario[1];
            Console.WriteLine($"Meu dicionário: {texto}");

            foreach (var item in diacionario)
            {
                Console.WriteLine($"Acessando a key: {item.Key}");
            }

            foreach (var item in diacionario)
            {
                Console.WriteLine($"Acessando a Value: {item.Value}");
            }*/

            #endregion

            #region Queue
            //Queue: ela usada para trabalha com filas, o primeiro a entrar é o primeiro a sair

            /*Queue<string> queue = new Queue<string>();
            //Enqueue: é uma função da classe para adicionar os valores
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");

            foreach (var item in queue) 
            {
                Console.WriteLine($"Dados da minha Queue: {item}");
            }

            //Peek(): uma função para pegar o primeiro item da fila
            var valor = queue.Peek();
            Console.WriteLine(valor);

            //Dequeue(): uma função para desempilar removendo da fila
            valor = queue.Dequeue();
            var valor2 = queue.Dequeue();
            Console.WriteLine(valor);
            Console.WriteLine(valor2);*/


            #endregion

            #region Stack
            //Stack: tem o mesmo padrão da lista genérica e tem o conceito lifo,
            //ultimo a entrar é o primeiro a sair

            Stack<string> stack = new Stack<string>();
            stack.Push("Alexander");
            stack.Push("Nathalia");

            //Pop(): está função recuper o primeiro valor da coleção e desempilhar 
            var nome = stack.Pop();
            var nome2 = stack.Pop();
            Console.WriteLine($"Nome é: {nome}");
            Console.WriteLine($"Nome é: {nome2}");

            foreach (var item in stack)
            {
                Console.WriteLine($"Minha Stack: {item}");
            }

            #endregion

            Console.WriteLine("Finishing my code");
        }
    }
}
