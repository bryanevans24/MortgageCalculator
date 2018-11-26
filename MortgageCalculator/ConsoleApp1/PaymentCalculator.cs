using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.obj
{
    public class PaymentCalculator
    {
        private const double MonthsPerYear = 12;

        /// <summary>
        /// The total purchase price of the item being paid for.
        /// </summary>
        public double PurchasePrice { get; set; }

        /// <summary>
        /// The total down payment towards the item being purchased.
        /// </summary>
        public double DownPayment { get; set; }

        /// <summary>
        /// Gets the total loan amount. This is the purchase price less
        /// any down payment.
        /// </summary>


        /// <summary>
        /// The annual interest rate to be charged on the loan
        /// </summary>
        public double InterestRate { get; set; }


        /// <summary>
        /// The term of the loan in years. This is the number of years
        /// that payments will be made.
        /// </summary>
        public double LoanTermYears { get; set; }

        /// <summary>
        /// Calculates the monthy payment amount based on current
        /// settings.
        /// </summary>
        /// <returns>Returns the monthly payment amount</returns>
        public double CalculatePayment(double purchasePrice, double downPayment, double interestRate, double loanTermYears
            , double yearTaxes, double homeInsurance)
        {
            double loanTermMonths = loanTermYears * 12;
            double loanAmount = purchasePrice - downPayment;
            double payment = 0;

            if (loanTermMonths > 0)
           {
                if (interestRate != 0)
                {
                    
                    double rate = interestRate / 100 / 12;
                    double denaminator = Math.Pow((1 + rate), loanTermMonths) - 1;
                    return (rate + (rate / denaminator)) * loanAmount + (yearTaxes / 12) + (homeInsurance / 12);

                }
                else payment = loanAmount / (double)loanTermMonths;
           }
            
            return payment + (yearTaxes / 12) + (homeInsurance / 12);
        }
    }
}
