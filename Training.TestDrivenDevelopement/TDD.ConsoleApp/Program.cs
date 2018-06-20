using System;
using System.Linq;

namespace TDD.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("if Salary>30000 tax = 10");
            //Console.WriteLine("if Salary>15000 tax = 7");
            //Console.WriteLine("if Salary<=15000 tax = Free");
            //Console.Write("How many job : ");
            //int job = Int32.Parse(Console.ReadLine());
            //int total = 0;
            //for (int i = 1; i <= job; i++)
            //{
            //    int sum = 0;
            //    Console.Write("job " + i + " :");
            //    string job2 = Console.ReadLine();
            //    Console.Write("Remuneration per hour  ");
            //    int paytohour = Int32.Parse(Console.ReadLine());
            //    Console.Write("How many hours?");
            //    int hour = Int32.Parse(Console.ReadLine());
            //    sum = paytohour * hour;
            //    Console.WriteLine("Salary to job " + i + ": " + sum);
            //    total += sum;
            //}

            //if (total < 10000)
            //{
            //    double total2 = total;
            //    Console.WriteLine(total2);
            //}
            //else if (total < 30001)
            //{
            //    double total2 = total * 0.93;
            //    Console.WriteLine(total2);
            //}
            //else
            //{
            //    double total2 = total * 0.8;
            //    Console.WriteLine(total2);
            //}
        }

        public string Grad(int score)
        {
            if (score >= 80)
            {
                return "A";
            }
            else if (score >= 70)
            {
                return "B";
            }
            else if (score >= 60)
            {
                return "C";
            }
            else if (score >= 50)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public bool check()
        {
            return true;
        }

    }
}
