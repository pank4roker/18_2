using System;
using System.Collections;
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
                Write("What do you want information about, newspaper(N)/magazine(M) or printed product(P): ");
                string print = ReadLine();
                WriteLine();
                switch (print.ToLower())
                {
                    case "n":
                        Newspaper newspaper = new Newspaper();
                        prod.Add(Newspaper.Input());
                        newspaper.Cost();
                        WriteLine();
                        break;
                    case "m":
                        Magazine magazine = new Magazine();
                        prod.Add(Magazine.Input());
                        magazine.Cost();
                        WriteLine();
                        break;
                    case "p":
                        foreach (var elem in prod)
                        {
                            elem.Info();
                            WriteLine();
                        }
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
