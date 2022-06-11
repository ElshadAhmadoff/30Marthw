using _31_03_2022_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_03_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool toContinue = true;
            Console.WriteLine("1 - Square\n2 - Rectangular\n0 - Quit\n");
        Start: Console.Write("Enter: ");
            int enter = Convert.ToInt32(Console.ReadLine());
            while (toContinue)
            {
                switch (enter)
                {
                    case 1:
                        Console.Write("\nPlease enter side of square: ");
                        int side = Convert.ToInt32(Console.ReadLine());
                        Square s = new Square(side);
                        Console.WriteLine(s.CalculateArea());
                        goto Start;
                        break;
                    case 2:
                        Console.Write("\nPlease enter width of the Rectangular: ");
                        int width = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please enter length of the Rectangular: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Rectangular r = new Rectangular(width, length);
                        Console.WriteLine(r.CalculateArea());
                        goto Start;
                        break;
                    case 0:
                        toContinue = false;
                        break;
                    default:
                        Console.WriteLine("\nPlease try again\n");
                        goto Start;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}