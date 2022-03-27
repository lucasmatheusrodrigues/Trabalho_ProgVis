using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ProgVis
{
    public class Calendario
    {
        public Byte Mes { get; set; }
        public UInt64 Ano { get; set; }



        // Verifição do mês
        public Boolean isMesValido()
        {
            if (Mes < 13 && Mes > 0)
            {
                return true;
            }
            else
            {

                Console.WriteLine("--------------------------------");
                Console.WriteLine("O MÊS deve seguir o formato numérico,\ntal como '3' para março,\ne, portanto, deve ser de 1 a 12.");
                Console.WriteLine("--------------------------------");

                return false;

            }
        }

        // Verificação do ano
        public Boolean isAnoValido()
        {
            if (Ano > 0 && Ano < 10000)
            {
                return true;
            }
            else
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("O ANO deve seguir o formato numérico,\ntal como '2022',\ne deve ser de 1 a 9999.");
                Console.WriteLine("--------------------------------");
                return false;

            }
        }

        public string gerarCalendario()
        {

            // Obter o primeiro dia do mês atual
            //Criando variavel mês do tipo DateTime, recebendo o ano e mês inseridos pelo usuário, e recebe o dia 1.
            var mes = new DateTime((int)Ano, Mes, 1);

            // Impressão do título com mês e ano 
            Console.WriteLine($"\n  {mes.ToString("MMMM")} de {mes.Year}");

          
            //Imppressão dos dias da semana
            Console.WriteLine("---------------------");
            Console.WriteLine(" D  S  T  Q  Q  S  S ");
            Console.WriteLine("---------------------");


            //var diaesquerda, recebe os dias que precisam estar em branco
            //var diaatual recebe a variavel mes do tipo DateTime

            var diaesquerda = (int)mes.DayOfWeek;
            var diaatual = mes;
           
            //A propriedade DaysInMonth retorna  a quantidade de dias no mes de um ano especificado.
            //A variavel interação: recebe o total de dias do mês mais os dias que precisam ficar em branco.
            //Será usada para parar o laço de repetição e escrever os dias conforme as condições
            var interacao = DateTime.DaysInMonth(mes.Year, mes.Month) + diaesquerda;

            for (int i = 0; i < interacao; i++)
            {
                //Preenche a quantidade de dias a esquerda com espaços vazios.
                if (i < diaesquerda)
                {
                    Console.Write("   ");
                }
                else
                {
                    //Escreve o dia - e adiciona 2 espaços para separar os dias.
                    Console.Write($"{diaatual.Day.ToString().PadLeft(2, ' ')} ");

                    // Quando já for escrito 7 dias contando os espaços vazios, será iniciado uma nova linha
                    if ((i + 1) % 7 == 0)
                    {
                        Console.WriteLine();
                    }

                    // Adiciona 1 dia ao 'diaatual' para na proxima repetição escrever o proximo dia.
                    diaatual = diaatual.AddDays(1);

                }

            }

            Console.WriteLine("\n---------------------");
            return "\n";
        }
    }
}
