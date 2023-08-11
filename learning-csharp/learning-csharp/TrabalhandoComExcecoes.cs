using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_csharp
{
    public class TrabalhandoComExcecoes
    {
        public void GerandoException()
        {            
            while (true)
            {
                Console.WriteLine("Informe um número: ");
                var numero = Console.ReadLine();

                int resultado = 500 / int.Parse(numero);

                Console.WriteLine("O resultado é: " + resultado);
            }
        }

        public void TratandoException() 
        {
            
            //Para fazer o tramento de erros, podemos usar o bloco try/catch 
            try
            {
                while (true)
                {
                    Console.WriteLine("Informe um número: ");
                    var numero = Console.ReadLine();

                    int resultado = 500 / int.Parse(numero);

                    Console.WriteLine("O resultado é: " + resultado);
                }
            }
            //DivideByZeroException é expection customizada para tratar erros de regra negócios
            catch (DivideByZeroException exceptionCustom)
            {
                //com a propriedade Message
                Console.WriteLine("Ocorreu um de divisão: " + exceptionCustom.Message);
                //com a propriedade StackTrace contem todo caminho do erro exibido
                Console.WriteLine("Stack do erro: " + exceptionCustom.StackTrace);
            }
            //Exception: com esse objeto podemos indentificar a causa do erro. 
            catch (Exception exception)
            {
                //com a propriedade Message
                Console.WriteLine("Ocorreu um erro: " + exception.Message);
                //com a propriedade StackTrace contem todo caminho do erro exibido
                Console.WriteLine("Stack do erro: " + exception.StackTrace);
            }            
        }
    }
}
