using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0; //creates and initalizes input variable
            int balance = 1000; //creates and initalizes balance variable

            while (input != 4) //loop for atm menu. It will continue to loop as long as the input variable does equal 4
            {
                Console.WriteLine("ATM Menu:"); //displays text 
                Console.WriteLine("1. Check Balance"); //displays text for the first option for user input
                Console.WriteLine("2. Deposit"); //displays text for the second option for user input
                Console.WriteLine("3. Withdraw"); //displays text for the third option for user input
                Console.WriteLine("4. Exit"); //displays text for the last option for user input
                Console.Write("Choose an option: "); //displays text asking for user input
                input = Convert.ToInt32(Console.ReadLine()); //converts user input into the input variable

                switch(input) //switch loop that will display the corrisponding data for the option the user inputed
                {
                    case 1: //case for the first option of user input
                        Console.WriteLine("Your balance is: " + balance); //displays the users balance
                        break; //breaks from switch loop
                    case 2: //case for the second option of user input
                        Console.Write("Enter deposite amount: "); //asks for user input
                        input = Convert.ToInt32(Console.ReadLine()); //converts user input into the input variable
                        balance = balance + input; //updates the balance value by adding the input to current balance
                        break; //breaks from switch loop
                    case 3: //case for the third option of user input
                        Console.Write("Enter withdraw amount: "); //asks for user input
                        input = Convert.ToInt32(Console.ReadLine()); //converts user input into the input variable
                        if (input > balance) //if else loop to determine if the user has enough funds for the withdrawl
                        {
                            Console.WriteLine("You do not have enough funds for this withdrawl"); //displays text to inform user they do not have enough funds
                        }
                        else //else option if the user does have enough funds
                        {
                            balance = balance - input; //updates the balance value by subtracting the input to current balance
                        }
                        break; //breaks from switch loop
                    case 4: //case for the last option of user input
                        break; //breaks from switch loop
                    default: //if the user inputed an invalid input, it defaults to default case
                        Console.WriteLine("Please enter a valid option"); //displays text to inform the user to input a valid input option
                        break; //breaks from switch loop
                }
            }

            Console.WriteLine("Have a nice day"); //displays a goodbye text

            Console.ReadLine(); //allows user to read program
        }
    }
}
