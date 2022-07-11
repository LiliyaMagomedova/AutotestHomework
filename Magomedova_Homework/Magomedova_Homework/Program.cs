using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magomedova_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks 1, 3, 5, 8 were done.");
            string taskNubmer;
            do {
                Console.WriteLine();
                Console.WriteLine("Enter task number to check result or enter 0 to quit:");
                taskNubmer = Console.ReadLine();
                switch (taskNubmer)
                {
                    case "1":
                        //задание 1
                        int min = Task1_Minimum();
                        Console.WriteLine($"Minimum element is: {min}"); ;
                        break;
                    case "3":
                        //задание 3
                        int sum = Task3_Sum();
                        Console.WriteLine($"Elements list sum: {sum}");
                        break;
                    case "5":
                        //задание 5
                        Task5_Random();
                        break;
                    case "8":
                        //задание 8
                        Console.WriteLine("Reversed massive is: ");
                        int[] reversedNumbers = Task8_Reverse();
                        for (int i = 0; i < reversedNumbers.Length; i++)
                        {
                            Console.Write($"{reversedNumbers[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter 1, 3, 5, 8 or enter 0 to quit");
                        break;
                }
            }
            while (true);
        }

        public static int Task1_Minimum()
        {
            List<int> numbers = new List<int> { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int min = numbers[0];
            int length = numbers.Count;
            for (int i = 1; i < length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }


        public static int Task3_Sum()
        {
            List<int> numbers = new List<int> { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int sum = 0;
            int numbersCount = numbers.Count;
            for (int i = 0; i < numbersCount; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Task5_Random()
        {

            Random rnd = new Random();
            string randomNumbersLengthString;
            int randomNumbersLength;
            bool isNum;

            Console.WriteLine("Enter list length: ");
            do
            {
                randomNumbersLengthString = Console.ReadLine();
                isNum = int.TryParse(randomNumbersLengthString, out randomNumbersLength);
            }
            while (!isNum);

            List<int> randomNumbers = new List<int>();
            Console.WriteLine("Random numbers list: ");
            for (int i = 0; i < randomNumbersLength; i++)
            {
                randomNumbers.Add(rnd.Next(1, 10));
                Console.Write($"{randomNumbers[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] Task8_Reverse()
        {
            int[] numbers = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int buffer;
            int halfLength = numbers.Length / 2;
            int numberLength = numbers.Length;
            for (int i=0; i<halfLength; i++)
            {
                buffer = numbers[i];
                numbers[i] = numbers[numberLength-i-1];
                numbers[numberLength-i-1] = buffer;
            }
            return numbers;
        }

    }
}
   
      

