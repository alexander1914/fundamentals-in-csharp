using System;

namespace learning_csharp
{
    public class TrabalhandoComDatas
    {
        #region DateTime

        public void DateTimes()
        {
            //DateTime: é possível trabalhar com data e hora passando pelo construtor do objeto
            var dateTime = new DateTime(2012, 08, 10, 18, 00, 00);

            //DateTime: é possível utilizar por propriedade com o método parse()
            var dateTime2 = DateTime.Parse("2023/08/10 18:30:00");

            //DateTime: é possível utilizar por propriedade
            var dateTime3 = DateTime.Now;
            var dateTime4 = DateTime.Today;

            //DateTimeOffset: é utilizando para trabalhar com datas específicas com timezone do País
            var dateOffset = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));

            Console.WriteLine("DateTime1: " + dateTime);
            Console.WriteLine("DateTime2: " + dateTime2);
            Console.WriteLine("DateTime3: " + dateTime3);
            Console.WriteLine("DateTime4: " + dateTime4);
            
            Console.WriteLine("DateTimeOffset: " + dateOffset.LocalDateTime);
            Console.WriteLine("DateTimeOffset: " + dateOffset.UtcDateTime);

            Console.WriteLine("Formantando uma Data: " + dateTime.ToString("dd-MM-yyyy"));
            Console.WriteLine("Formantando uma Data com Hora: " + 
                dateTime.ToString("dd-MM-yyyy HH:mm:ss"));

        }

        #endregion

        #region Subtraindo Datas
        // é possível fazer subtração de datas com o DateTime

        public void SubtraindoDatas()
        {
            DateTime dateTime = DateTime.Now;
            DateTime dateTime2 = DateTime.Parse("2023-01-01");

            //var diff = dateTime - dateTime2;

            //Utilizando o metódo Subtract() para fazer a subtração
            var diff = dateTime.Subtract(dateTime2);    

            Console.WriteLine("Quantos dias tem de diferença: " + (int)diff.TotalDays);
            Console.WriteLine("Quantas horas tem de difereça: " + (int)diff.TotalHours);
        }

        #endregion

        #region AdicionandoDiasMesAno
        // São métodos para adicionar dias, meses, anos sobre a data atual

        public void AdicionandoDiasMesesAnos()
        {
            DateTime date = DateTime.Now;
            
            Console.WriteLine("Adicionando Dias sobre a data atual: " + 
                date.AddDays(2).ToString("dd-MM-yyyy HH:mm:ss"));
            
            Console.WriteLine("Adicionando Meses sobre o mês atual: " + 
                date.AddMonths(3).ToString("dd-MM-yyyy HH:mm:ss"));

            Console.WriteLine("Adicionando Anos sobre ano atual: " + 
                date.AddYears(4).ToString("dd-MM-yyyy HH:mm:ss"));
        }

        #endregion

        #region AdicionandoHorasMinutosSecundos
        // São métodos para adicionar horas, minutos e secundos sobre a hora atual

        public void AdicionandoHorasMinutosSecundos()
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine("Hora atual: " + dateTime.ToString("HH:mm:ss"));

            Console.WriteLine("Adicionando Horas sobre a hora atual: " +
                dateTime.AddHours(1).ToString("HH:mm:ss"));

            Console.WriteLine("Adicionando Minutos sobre o minuto atual: " +
                dateTime.AddMinutes(10).ToString("HH:mm:ss"));

            Console.WriteLine("Adicionando Segundos sobre segundo atual: " +
                dateTime.AddSeconds(20).ToString("HH:mm:ss"));

        }

        #endregion

        #region DiasDasSemana
        // é um método para recuperar o dia da semana atual

        public void DiasDaSemana()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Dia da Semana: " + dateTime.DayOfWeek);
        }

        #endregion

        #region DateOnly
        // é um objeto que trabalha apenas com datas novo recurso do .net 6
        
        public void DateOnlyEmAcao()
        {
            var dateOnly = DateOnly.Parse("2022-08-10");
            
            Console.WriteLine("DateOnly: " + dateOnly);
            Console.WriteLine("DateOnly Formatado: " + dateOnly.ToString("dd/MM/yyyy"));
        }

        #endregion

        #region TimeOnly
        //é um objeto para trabalhar apenas com hora do .net 6

        public void TimeOnlyEmAcao()
        {
            
            // é possível usar pelo construtor do objeto
            var outraVariavel = new TimeOnly(09, 00, 00);
            
            // é possível usar pelo método parse()
            TimeOnly somenteHora = TimeOnly.Parse("09:00:00");

            Console.WriteLine("TimeOnly opção 1: " + somenteHora);
            Console.WriteLine("TimeOnly opção 2: " + outraVariavel);
        }

        #endregion
    }
}
