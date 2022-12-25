
namespace Lesson1
{

    class Program
    {

        static void Main(string[] args)
        {

            double num1;
            double num2;
            string choice;
            double answer;
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Enter frist number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.Write("select your choice : \n+ \n-\n/\n*\n  ");
            choice = Console.ReadLine();


            switch (choice)
            {

                case "-":
                    answer = num1 - num2;
                    break;

                case "+":
                    answer = num1 + num2;
                    break;

                case "/":
                    if (num2==0)
                    {
                        Console.WriteLine("Second number should be more than 0");
                    }

                    answer = num1 / num2;


                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                default:
                    answer = 0;
                    break;
            }
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine(num1.ToString() + " " + choice + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();

        }

    }
}
