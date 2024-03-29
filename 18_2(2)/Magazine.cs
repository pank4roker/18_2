﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_2_2_
{
    class Magazine : Printedprod
    {
        int edition;
        public int Edition { get => edition; set => edition = value; }

        double price;
        public double Price { get => price; set => price = value; }
        public Magazine() { }   
        public Magazine(string name,int edition, double price)
        {
            this.Name = name;
            this.edition = edition;
            this.Price = price;
        }
        public override void Info()
        {
            WriteLine($"Name: {Name}\nEdition: {edition}\nPrice: {price}\nCost edition: {Cost()}");
        }
        public override double Cost()
        {
            return edition * price;
        }
        public static Magazine Input()
        {
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the circulation quantity: ");
            int edition = Convert.ToInt32(ReadLine());
            Write("Enter the price: ");
            double price = Convert.ToDouble(ReadLine());
            return new Magazine(name,edition,price);
        }


    }
}
