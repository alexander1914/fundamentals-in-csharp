using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting my project");

            #region Variaveis

            int year = 32;
            string name = "Alexander Albuquerque Oliveira";
            //m sempre no final de um decimal
            decimal salary = 20.000m;
            //f sempre no final de um floal
            float discont = 700.65f;
            double taxe = 5.0;
            char flag = 'A';
            bool active = true;

            #region Const: uma const é um valor que não pode ser alterado
            const string description = "this course about fundamentls of C#";
            #endregion


            Console.WriteLine($"My year is : {year}");
            Console.WriteLine($"My name is : {name}");
            Console.WriteLine($"My salary is : {salary}");
            Console.WriteLine($"My taxe is : {taxe}");
            Console.WriteLine($"My discont is : {discont}");
            Console.WriteLine($"My flag is : {flag}");
            Console.WriteLine($"Am I active? : {active}");

            Console.WriteLine(description);

            Console.WriteLine("Finishing my project");


            #endregion
        }
    }
}
