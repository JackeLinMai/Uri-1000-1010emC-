﻿using System;
using System.Globalization;

namespace Uri1001
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = (3.14159 * raio * raio);

            Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
