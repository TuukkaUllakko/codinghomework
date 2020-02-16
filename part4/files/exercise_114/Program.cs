using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                String input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else
                {
                    number++;
                }
            }

            Console.WriteLine(number);

        }
    }
}
