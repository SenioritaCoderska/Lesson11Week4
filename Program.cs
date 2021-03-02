using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {   //Call main method 
            EvenOrOdd();
        }

        private static void EvenOrOdd()
        {  //Method to operate over user input
            try
            {
                // Ask nicely
                Console.WriteLine($"{Environment.NewLine} Hello! { Environment.NewLine} Please provide one number...");
                //Collect input and veriify the number
                Console.WriteLine(CheckInput());
                //Ask what to do next?
                UserActionsManagment();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                EvenOrOdd();
            }

        }

        private static string CheckInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                throw new Exception($"{Environment.NewLine} Please provide the number as an input...");
            }
            return (input % 2==0 ? "Your number is even!" : "Your number is odd!");
        }
        private static void UserActionsManagment()
        {
            //What do you want to do next?
            Console.WriteLine("What do you want to do next ? For exit press (e) to continue press (c).");
            //Perfomr an action depend on user input
            var keyInput = Console.ReadKey().Key.ToString().ToLower();

            switch (keyInput)
            {
                case "e":
                    Environment.Exit(0);
                    break;
                case "c":
                    EvenOrOdd();
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine} No appropriate action chosen!");
                    UserActionsManagment();
                    break;
            }
        }
    }
}
