﻿using System;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фирму: ");
            string firm = Console.ReadLine();

            Console.WriteLine("Введите тип: ");
            string type = Console.ReadLine();

            Console.WriteLine("Введите диагональ: ");
            float diagonal = (float)Convert.ToDouble(Console.ReadLine());

            MonitorClass MC = new(firm, type, diagonal);

            Console.WriteLine(MC.Firm + " " + MC.Type + " " + MC.Diagonal);
        }
    }
    class MonitorClass
    {
        public string Firm;
        public string Type;
        public float Diagonal;

        public MonitorClass(string firm, string type, float diagonal)
        {
            Firm = firm;
            Type = type;
            Diagonal = diagonal;
        }
    }
}
