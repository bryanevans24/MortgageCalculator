using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator
{
    public class Mortgage
    {
        public int AddressId { get; set; }

        public int MortgageId { get; set; }

        public float PurchasePrice { get; set; }

        public float DownPayment { get; set; }

        public float InterestRate { get; set; }

        public float TermLength { get; set; }

        public float Taxes { get; set; }

        public float Insurance { get; set; }

        public float Payment { get; set; }

        public string UserName { get; set; }
    }
}
