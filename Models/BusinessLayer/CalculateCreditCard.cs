using QulificationToolForCreditCard.Models.BAL.Interface;
using System;

namespace QulificationToolForCreditCard.Models.BAL
{
    public class CalculateCreditCard : ICalculateCreditCard
    {
       private const  decimal _income = 30000M;

        public int CalculateCreditCardDetails(DateTime dateTime, decimal annualIncome)
        {
            int result = (int)CreditCardDetails.None;
            if (dateTime != null)
            {
                int age = GetAge(dateTime);
                if (age > 18)
                {
                    result = (decimal.Compare(_income, annualIncome) <= 0)? (int)CreditCardDetails.Barclay : (int)CreditCardDetails.Vanquis;
                }
            }
            return result;
        }

        private int GetAge(DateTime dateTime)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateTime.Year;

            //if the person is born in leap year.
            if (DateTime.Now.DayOfYear < dateTime.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
