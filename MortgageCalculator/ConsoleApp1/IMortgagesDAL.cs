using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator
{
    public interface IMortgagesDAL
    {
        IList<Mortgage> GetAllMortgages();

        void SubmitMortgage(Mortgage mortgage);

        void SubmitAddress(Address address);
    }
}
