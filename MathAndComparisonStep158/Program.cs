﻿using System;


namespace MathAndComparisonStep158
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Punch in a number please");
            string enter = Console.ReadLine();
            double number = Convert.ToDouble(enter);
            double mult = 50 * number;
            double add = 25 + number;
            double div = 12.5 / number;
            bool great = number > 50;
            double left = number % 7;
            Console.WriteLine("x 50 = " + mult + ", + 25 = " + add + ", / by 12.5 = " + div +
                ", > 50 = " + great + " ,remaining = " + left);
            Console.ReadLine();
        }
    }
}
