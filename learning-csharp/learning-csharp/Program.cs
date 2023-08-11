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
            Console.WriteLine();

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

            /*LinkedList<Int32> myList = new LinkedList<Int32>();

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
            }*/

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

            /*Stack<string> stack = new Stack<string>();
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
            }*/

            #endregion

            #region IF/ELSE IF e ELSE / Estrutura de Controle
            //Para fazer validações com essas estruturas de controle

            /*int diaDaSemana = 0;
            bool diaDeTrabalhar = true;

            if(diaDaSemana == 7 && diaDeTrabalhar)
            {
                Console.WriteLine("Hoje é sexta-feira beBê bora trabalhar !!!");
            }
            else if(diaDaSemana == 0 && diaDeTrabalhar){
                Console.WriteLine("Hoje é Domingo, porém hoje eu vou trabalhar");
            }
            else
            {
                Console.WriteLine("Hoje é Sábado bora descansar");
            }*/

            #endregion

            #region SWITCH / Estrutura de Controle
            //é uma estrutura de dados simular o else if porém é mais adequada
            // mais de uma instrução para seu programa

            /*int diaDaSemana = 5;

            switch (diaDaSemana)
            {
                case 0:
                    Console.WriteLine("Hoje é Domingo");
                    break;
                case 1:
                    Console.WriteLine("Hoje é Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Hoje é Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("Hoje é Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Hoje é Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Hoje é Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Hoje é Sábado dia de Culto bora");
                    break;

                default:
                    Console.WriteLine("Não sei que dia é hoje shshshsh");
                    break;
            }*/

            #endregion

            #region FOR / Estrutura de Controle
            //FOR:  é um conhecido como lanço de repetição, 
            // é bastante popular quando queremos interação dentro de uma coleção

            /*int numeroDaTabuada = 7;
            List<int> numeros =  new List<int>();
            numeros.Add(0);
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);

            Console.WriteLine($"Essa é a Tabuada do: {numeroDaTabuada}");

            for (int i = 0; i < numeros.Count; i++)
            {
                int resultado = numeroDaTabuada * numeros[i];                
                Console.WriteLine($"{numeroDaTabuada} X {numeros[i]} = {resultado}");
            }*/

            #endregion

            #region FOREACH / Estrutura de Controle
            //Foreach: é uma estrutura de controle, que usamos para acessar
            //um item de uma coleção por exemple LinkedList.
            //E também não precisar ter um indice para acessar os dados

            /*LinkedList<int> libertadoresPalmeiras = new LinkedList<int>();
            libertadoresPalmeiras.AddFirst(99);
            libertadoresPalmeiras.AddFirst(20);
            libertadoresPalmeiras.AddLast(21);

            foreach (var item in libertadoresPalmeiras) 
            {
                Console.WriteLine($"Campeão da Libertadores em {item}");                
            }

            Console.WriteLine("Esse seremos Campeões mais uma vez !!!");
            Console.WriteLine("AVANTI PALESTRA, LET'S GO PALMEIRAS !!!");*/

            #endregion

            #region WHILE DO WHILE / Estrutura de Controle
            //WHILE OU DO WHILE: é uma estrutura de controle para fazer um laço de repitição

            /*int i  = 0;
            
            while (i < 10) 
            {
                Console.WriteLine($"var i: {i}");
                i++;
            }

            int x = 0;
            do
            {
                Console.WriteLine($"var x: {x}");
                x++;
            } while (x < 20);*/

            #endregion

            #region BREAK E CONTINUE
            //BREAK: após uma validação podemos interromper a execução do programa
            //CONTINUE: é utilizado para processeguir a execução de um bloque código

            /*var i = 0;
            while (i < 5) 
            {
                if (i < 2)
                {
                    Console.WriteLine("Continue ....");
                    i++;
                    continue;
                }
                
                Console.WriteLine($"var i = {i}");
                i++;

                if (i == 2)
                {
                    Console.WriteLine($"Valor de i é igual a 2: {i}");
                    break;
                }
            }*/

            #endregion

            #region Convert/Parse

            /*Conversores();
            ConversoresComConvert();
            
            static void Conversores(){

                int numero = int.Parse("1");
                bool verdadeiro = bool.Parse("true");

                Console.WriteLine(numero);
                Console.WriteLine(verdadeiro);

            }

            static void ConversoresComConvert()
            {
                int numero = Convert.ToInt32("1");
                double numero2 = Convert.ToDouble("1");
                Console.WriteLine($"Usando a Classe Convert : {numero}");
                Console.WriteLine($"Usando a Classe Convert : {numero2}");
            }*/

            #endregion

            #region TryParse
            // Ele recebe um valor e tem um valor de saida após a conversão.
            // Temos o TryParse para todos os tipos primitivos do c#.

            /*tryParse();
            
            static void tryParse()
            {
                var numero = "123456789";
                int numeroConvertido;

                if (int.TryParse(numero, out numeroConvertido))
                {
                    Console.WriteLine("Numero foi convertido com sucesso !");
                }

                Console.WriteLine(numeroConvertido);
            }*/

            #endregion

            #region Trabalhando com Strings

            TrabalhandoStrings trabalhandoStrings = new TrabalhandoStrings();
            //trabalhandoStrings.ConverterParaLetrasMinusculas();
            //trabalhandoStrings.ConverterParaLetrasMaiusculas();
            //trabalhandoStrings.Substrings();
            //trabalhandoStrings.Range();
            //trabalhandoStrings.Contains();
            //trabalhandoStrings.MetodosTrims();
            //trabalhandoStrings.StartWithEndWith();
            //trabalhandoStrings.Replace();
            //trabalhandoStrings.Length();

            #endregion

            #region Trabalhando com Datas

            TrabalhandoComDatas trabalhandoComDatas = new TrabalhandoComDatas();
            //trabalhandoComDatas.DateTimes();
            //trabalhandoComDatas.SubtraindoDatas();
            //trabalhandoComDatas.AdicionandoDiasMesesAnos();
            //trabalhandoComDatas.AdicionandoHorasMinutosSecundos();
            //trabalhandoComDatas.DiasDaSemana();
            //trabalhandoComDatas.DateOnlyEmAcao();
            //trabalhandoComDatas.TimeOnlyEmAcao();

            #endregion

            #region Trabalhando com Exceções

            TrabalhandoComExcecoes trabalhandoComExcecoes = new TrabalhandoComExcecoes();
            //trabalhandoComExcecoes.GerandoException();
            //trabalhandoComExcecoes.TratandoException();

            #endregion

            Console.WriteLine();
            Console.WriteLine("Finishing my code");
        }
    }
}
