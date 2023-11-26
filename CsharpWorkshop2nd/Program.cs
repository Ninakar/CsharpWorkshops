namespace CsharpWorkshop2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 12 + 31;
            Console.WriteLine(n);
            var k = 12 - 31;
            Console.WriteLine(k);
            var r = 12 * 31;
            Console.WriteLine(r);
            var l = 12 / 31;
            Console.WriteLine(l);

            bool logic1 = false;
            if (logic1)
                Console.WriteLine("This will not print");

            var healthInsuranceLimit = 2000;
            bool lessThanIssuedLimit = healthInsuranceLimit < 3000;
            if (lessThanIssuedLimit)
                Console.WriteLine("Client has no problem");

            var number1 = 30.2;
            var number2 = 3;
            var number3 = 4;
            var number4 = 3;
            Console.WriteLine(number1 == number2);
            Console.WriteLine(number2 == number3);
            Console.WriteLine(number2 == number4);

            Console.WriteLine("Calculator");
            Console.WriteLine("Meaning of the symbols:");
            Console.WriteLine("+ Add");
            Console.WriteLine("- Substract");
            Console.WriteLine("* Multiply");
            Console.WriteLine("/ Divide");
            Console.WriteLine("% Ramainder after Division");

            Console.WriteLine("Enter the 1st variable");
            var nummer1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Use arithmetic sign");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the 2nd variable");
            var nummer2 = Convert.ToInt32(Console.ReadLine());

            if (symbol == '+')
            {
                Console.WriteLine(nummer1 + nummer1);
            }
            else if (symbol == '_')
            {
                Console.WriteLine(nummer1 - nummer1);
            }
            else if (symbol == '*')
            {
                Console.WriteLine(nummer1 * nummer1);
            }
            else if (symbol == '/')
            {
                Console.WriteLine(nummer1 / nummer1);
            }
            else if (symbol == '%')
            {
                Console.WriteLine(nummer1 % nummer1);
            }
            else
            {
                Console.WriteLine("Incorrect Manipulation");
            }

            Console.WriteLine("The second Calculator");
            Console.WriteLine("Enter the 1st variable:");
            var nummerO1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Use arithmetic sign");
            char operationSymbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the 2nd variable:");
            var nummerO2 = Convert.ToInt32(Console.ReadLine());

            switch (operationSymbol)
            {
                case '+':
                    Console.Write($"The answer is {nummerO1 + nummerO2}");
                    break;
                case '_':
                    Console.Write($"The answer is {nummerO1 + nummerO2}");
                    break;
                case '*':
                    Console.Write($"The answer is {nummerO1 * nummerO2}");
                    break;
                case '/':
                    Console.Write($"The answer is {nummerO1 / nummerO2}");
                    break;
                case '%':
                    Console.Write($"The answer is {nummerO1 % nummerO2}");
                    break;
                case 'F':
                    Console.WriteLine("Incorrect manipulation");
                    break;
            }

        }
    }
}
