using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QulificationToolForCreditCard.Models.BAL.Interface
{
    public interface ICalculateCreditCard
    {
        int CalculateCreditCardDetails(DateTime dateTime, decimal annualIncome);
    }
}
