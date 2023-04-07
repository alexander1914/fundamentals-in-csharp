using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting my project");

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

            int numero1 = 10;
            int numero2 = 20;

            bool valido = numero2 > numero1 && 8 > 5;
            Console.WriteLine($"O Resultado é: {valido}");

            bool valido2 = numero2 > numero1 || 4 > 5;
            Console.WriteLine($"O Resultado é: {valido2}");

            bool valido3 = !(numero2 > 10);
            Console.WriteLine($"O Resultado é: {valido3}");

            #endregion

            Console.WriteLine("Finishing my project");
        }
    }
}
