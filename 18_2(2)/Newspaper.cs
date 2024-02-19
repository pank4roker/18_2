using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_2_2_
{
    class Newspaper : Printedprod
    {
        double costlist;
        public double Costlist { get => costlist; set => costlist = value; }

        int countlist;
        public int Countlist { get => countlist; set => countlist = value; }
        int edition;
        public int Edition { get => edition; set => edition = value; }
        public Newspaper() { }
        public Newspaper(string name,double costlist,int countlist,int edition)
        {
            this.Name = name;
            this.costlist = costlist;
            this.countlist = countlist;
            this.edition = edition;
        }
        public override void Info()
        {
            WriteLine($"Name: {Name}\nEdition: {edition}\nPrice list: {costlist}\nCount list: {countlist}\n Cost edition: {Cost()}");
        }
        public override double Cost()
        {
            return (costlist*countlist)*edition;
        }
        public static Newspaper Input()
        {
            Write("Enter the surname: ");
            string surname = ReadLine();
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the date of birth: ");
            DateTime dateTime = DateTime.Parse(ReadLine());
            Write("Enter the minimal salary: ");
            double p = Convert.ToDouble(ReadLine());
            Write("Enter the sales volume: ");
            int scope = Convert.ToInt32(ReadLine());
            return new Manager(surname, name, dateTime, p, scope);
        }



    }
}
