//using ConsoleApp1.obj;
//using System;

//namespace ConsoleApp1
//{
//    public class Program : obj.PaymentCalculator

//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Calculate your new mortgage!");
//            Console.WriteLine();

//            Console.WriteLine("What is your purchase price?");
//            double purchasePrice = double.Parse(Console.ReadLine());
//            Console.WriteLine();

//            Console.WriteLine("What is your down payment?");
//            double downPayment = double.Parse(Console.ReadLine());
//            Console.WriteLine();

//            Console.WriteLine("What is the interest rate?");
//            double interestRate = double.Parse(Console.ReadLine());
//            Console.WriteLine();

//            Console.WriteLine("How long will your loan be? 15 years or 30 years?");
//            double loanTermYears = double.Parse(Console.ReadLine());
//            Console.WriteLine();

//            Console.WriteLine("What are your yearly taxes?");
//            double yearTaxes = double.Parse(Console.ReadLine());
//            Console.WriteLine();

//            Console.WriteLine("How much is your Homeowner's Insurance per year?");
//            double homeInsurance = double.Parse(Console.ReadLine());
//            Console.WriteLine();

            
//            double InterestRate = interestRate;
//            double LoanTermYears = loanTermYears;
//            double YearTaxes = yearTaxes;
//            double HomeInsurance = homeInsurance;

//            //calculate payment with taxes and insurance
//            PaymentCalculator calculatePayment = new PaymentCalculator();

//            double printPayment = calculatePayment.CalculatePayment(purchasePrice, downPayment, interestRate, loanTermYears, yearTaxes, homeInsurance);



//            Console.WriteLine($"Your new mortgage, including taxes and insurance is {printPayment}. ");

//        }












//    }
//}

