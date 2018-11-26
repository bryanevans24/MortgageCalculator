using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator
{
    public class MortgageException : Exception
    {
        /// <summary>
        /// Displays thrown error message
        /// </summary>
        /// <param name="message"></param>
        public MortgageException(string message) : base(message)
        {
            return ;
        }
    }
}
