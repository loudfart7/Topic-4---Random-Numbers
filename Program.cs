using System.ComponentModel.Design;
using System.Reflection.Emit;

namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Joel
            //Borders --->   ┌──────┐ └──────┘
            int min, max, random_number;
            Random generator = new Random();
              
            //Part 1

            Console.WriteLine("┌───────────────────────┐");
            Console.WriteLine(" Part 1: Random Integers");
            Console.WriteLine("└───────────────────────┘");
            Console.WriteLine();

            Console.Write("Enter a min value and amax for your randome number generator: ");
            Console.WriteLine();

            Console.Write("MIN: ");
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("MAX: ");
            while (!int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                Console.WriteLine();
            }

            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            random_number = generator.Next(min, max+1);
            Console.WriteLine();

            Console.WriteLine($"Random number generated: {random_number}");

            Console.WriteLine();
            Console.WriteLine("┌───────────────────────┐");
            Console.WriteLine(" PRESS ENTER TO CONTINUE ");
            Console.WriteLine("└───────────────────────┘");
            Console.ReadLine();
            Console.Clear();

            //Part 2

            int die1, die2, die_sum;

            Console.WriteLine("┌───────────────────┐");
            Console.WriteLine(" Part 2: Dice Roller");
            Console.WriteLine("└───────────────────┘");
            Console.WriteLine();

            Console.WriteLine("Press ENTER to roll 2 dice:");
            Console.ReadLine();

            die1 = generator.Next(7);
            die2 = generator.Next(7);

            Console.WriteLine($"Die 1: {die1}");
            Console.WriteLine($"Die 2: {die2}");
            Console.WriteLine();

            die_sum = die1 + die2;
            Console.WriteLine($"TOTAL SUM: {die_sum}");

            Console.WriteLine();
            Console.WriteLine("┌───────────────────────┐");
            Console.WriteLine(" PRESS ENTER TO CONTINUE ");
            Console.WriteLine("└───────────────────────┘");
            Console.ReadLine();
            Console.Clear();

            //Part 3

            int dcml_round = 0;
            double num;

            Console.WriteLine("┌──────────────────────────────┐");
            Console.WriteLine(" Part 3: Random Decimal Numbers");
            Console.WriteLine("└──────────────────────────────┘");
            Console.WriteLine();

            Console.Write("How many decimal places would you like your generated number to round up to?: ");
            dcml_round = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out dcml_round))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                Console.WriteLine();
            }

            Console.WriteLine() ;

            Console.WriteLine("Generating 3 values from your previous min and max numbers ("+min+","+max+"): ");

            //
            Console.WriteLine() ;
            num = (Math.Round((random_number = generator.Next(min, max))+(generator.NextDouble()), dcml_round));

            if (num < max)
                num = max;

            Console.WriteLine(num);

            Console.WriteLine();
            num = (Math.Round((random_number = generator.Next(min, max)) + (generator.NextDouble()), dcml_round));

            if (num < max)
                num = max;

            Console.WriteLine(num);

            Console.WriteLine();
            num = (Math.Round((random_number = generator.Next(min, max)) + (generator.NextDouble()), dcml_round));

            if (num < max)
                num = max;

            Console.WriteLine(num);
            //

            Console.WriteLine();
            Console.WriteLine("┌───────────────────────┐");
            Console.WriteLine(" PRESS ENTER TO CONTINUE ");
            Console.WriteLine("└───────────────────────┘");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
