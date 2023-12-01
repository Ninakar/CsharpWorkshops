using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Transactions;

namespace CsharpTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] departement1 = { "Cybersecurity", "Analysts", "Software Developers", "Infrastructure", "dbAdmins", "DevOps" };
            Console.WriteLine(departement1[0]);
            Console.WriteLine(departement1[1]);
            Console.WriteLine(departement1[2]);
            Console.WriteLine(departement1[3]);
            Console.WriteLine(departement1[4]);

            int[] floor = { 1, 2, };
            Console.WriteLine(floor[0]);
            Console.WriteLine(floor[1]);

            string[] departement2 = { "Strategy and Politics", "Administration" };
            departement2[0] = "Support";
            Console.WriteLine(departement2[0]);
            Console.WriteLine(departement2[1]);

            string[] departementNew = { "x", "y", "z" };
            Console.WriteLine(departementNew.Length);

            string[] departement3 = { "Moderator", "Consultant", "m", "n", "l" };
            for (int a = 0; a < departement3.Length; a++)
            {
                Console.WriteLine(departement3[a]);
            }

            string[] departement4 = { "Moderator1", "Consultant1", "Administrator" };
            Console.WriteLine(departement4.Length);

            string[] frontEnd = new string[2] { "html", "css" };
            Console.WriteLine(frontEnd[0]);
            Console.WriteLine(frontEnd[1]);

            string[] programLanguages = new string[] { "Php", ".net", "Java", "Phyton", "..." };
            Console.WriteLine(programLanguages[0]);

            string[] backEndTechnology;
            backEndTechnology = new string[] { "mysql", "apach", "oracle" };
            Console.WriteLine(backEndTechnology[2]);
            Console.WriteLine($"In my organization we use {backEndTechnology[0]}");

            int[] employees = { 1, 2, 3, 4, 5, 6, 7, 8, };
            foreach (var employedStatus in employees)
            {
                Console.WriteLine(employedStatus);
            }

            int[] employer = { 9, 10, 11, 12 };
            foreach (var employerStatus in employer)
            {
                Console.Write($"{employerStatus} ");
            }

            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine(alphabet[c]);
            }

            double[] calculationModule = new double[5] { 10.2, 5.8, 4.7, 3.3, 5.5 };
            int b = 0;
            while (b < 4)
            {
                Console.WriteLine(calculationModule[b]);
                b++;
            }

            var numbers = new double[5];
            Console.WriteLine("Input the 5 numbes");
            Console.WriteLine("Please enter the 1st number:");
            numbers[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd number:");
            numbers[1] = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the 3rd number:");
            numbers[2] = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the 4th number:");
            numbers[3] = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the 5th number:");
            numbers[4] = double.Parse(Console.ReadLine());

            int i = 0;
            double sum = 0;
            double number;
            Console.Write("Count of Numbers: ");
            double n = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                if (i == n)
                {
                    break;
                }
                Console.Write("Number {0} : ", i + 1);
                number = double.Parse(Console.ReadLine());
                sum += number;
                i++;

            }

            Console.WriteLine("Average of numbers: " + (sum / n));
            Console.ReadKey();

            double max = numbers[0]; 
            for (i = 0; i < numbers.Length; i++)
            {
             if (numbers[i]>max) 
                {
                  max = numbers[i];
                }
            }

            Console.WriteLine($"Maximum Number is {max}");

            double min = numbers[0];
            for (i=0; i < numbers.Length;i++) 
            {
                if (numbers[i]< min) 
                {
                    min = numbers[i];   
                }
            }
            Console.WriteLine($"Minimum Number is {min}");

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[numbers.Length-1]);

            Console.WriteLine("Print numbers from 15 to 23");
            for (i = 15; i <24; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Divided by 3: ");
            for (i = 0; i <= numbers.Length-1; i++) 
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine($"{numbers[i]} is divisible by three");
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} is not divisible by three");
                }
            }

        }
    
    }
    
}
