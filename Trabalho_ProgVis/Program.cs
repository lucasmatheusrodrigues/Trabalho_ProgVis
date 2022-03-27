using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ProgVis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string m;
            string a;

            Calendario c = new Calendario();

            do
            {
                try
                {
                    Console.Write("Digite o mês desejado: ");
                    m = Console.ReadLine();
                    c.Mes = Byte.Parse(m);
                }
                catch (Exception)
                {
                }

            } while (c.isMesValido() == false);


            do
            {
                try
                {

                    Console.Write("Digite o ano desejado: ");
                    a = Console.ReadLine();
                    c.Ano = UInt64.Parse(a);
                }
                catch (Exception)
                {
                }
            } while (c.isAnoValido() == false);

            Console.WriteLine($"\n{c.gerarCalendario()}");
        }
    }
}
