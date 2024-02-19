using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_2_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Printedprod> prod = new List<Printedprod>();
            while (true) 
            {
                Write("What do you want information about, newspaper(N) or magazine(M): ");
                string print = ReadLine();
                WriteLine();
                switch (print.ToLower())
                {
                    case "n":
                        Newspaper newspaper = new Newspaper();
                        prod.Add(Newspaper.Input());
                        newspaper.Info();
                        WriteLine();
                        break;
                    case "m":
                        Magazine magazine = new Magazine();
                        prod.Add(Magazine.Input());
                        magazine.Info();
                        WriteLine();
                        break;
                    case "exit": return;
                    default:
                        WriteLine("You entered wrong letter!");
                        break;
                }
            }
            ReadKey();
        }
    }
}
