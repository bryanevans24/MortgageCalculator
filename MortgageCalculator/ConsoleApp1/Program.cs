using ConsoleApp1.obj;
using MortgageCalculator;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        static MortgagesDAL _mortgagesDAL;
        static void Main(string[] args)
        {
            _mortgagesDAL = new MortgagesDAL();

            var mortgage = new Mortgage();
            var address = new Address();

            Console.WriteLine("Calculate your new mortgage!");
            Console.WriteLine();

            Console.WriteLine("Please create or enter your User Name?");
            mortgage.UserName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your purchase price?");
            mortgage.PurchasePrice = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is your down payment?");
            mortgage.DownPayment = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is the interest rate?");
            mortgage.InterestRate = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How long will your loan be? 15 years or 30 years?");
            mortgage.TermLength = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What are your yearly taxes?");
            mortgage.Taxes = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How much is your Homeowner's Insurance per year?");
            mortgage.Insurance = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //calculate payment with taxes and insurance
            PaymentCalculator calculatePayment = new PaymentCalculator();

            double printPayment = calculatePayment.CalculatePayment(mortgage.PurchasePrice, mortgage.DownPayment, mortgage.InterestRate, mortgage.TermLength, mortgage.Taxes, mortgage.Insurance);

            // Displays Mortgage Payment
            Console.WriteLine($"Your new mortgage, including taxes and insurance is ${printPayment}. ");

            Console.WriteLine("Would you like to SAVE this mortgage to an address, Y or N?");
            string input = Console.ReadLine();

            if(input == "N")
            {
                Console.WriteLine("Would you like to try another query, Y or N?");
                string input2 = Console.ReadLine();
                if (input2 == "N")
                {
                    Console.WriteLine("Thank you and goodbye!");
                }
                else
                {
                    Console.WriteLine("Press ENTER to start over");
                }
            }
            else
            {
                _mortgagesDAL.SubmitMortgage(mortgage);
                Console.WriteLine("What is the property street address?");
                address.Street = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("What city is the property located in?");
                address.City = Console.ReadLine();
                _mortgagesDAL.SubmitAddress(address);
            }
        }












    }
}

