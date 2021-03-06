using System;

namespace CollatzConjecture {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("I put Collatz conjecture in C# idk why");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Enter the number you wish to start with.");

            int startNumber = int.Parse(Console.ReadLine());
            int number = startNumber, oddSteps = 0, eventSteps = 0;
            string equation = startNumber + " ";

            while (number != 1) {
                if (number % 2 == 0) {
                    number = number / 2;
                    equation += "/ 2 = " + number + " ";
                    eventSteps++;
                } else {
                    number = (number * 3) + 1;
                    equation += "* 3 + 1 = " + number + " ";
                    oddSteps++;
                }
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Start Number: " + startNumber);
            Console.WriteLine("Steps: " + (oddSteps + eventSteps));
            Console.WriteLine("Odd Steps: " + oddSteps);
            Console.WriteLine("Even Steps: " + eventSteps);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(equation);
            Console.WriteLine("---------------------------------------------");
        }
    }
}
