using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace QulificationToolForCreditCard.CustomValidation
{
    public class ValidateDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            CultureInfo enUS = new CultureInfo("en-US");

            if (DateTime.TryParseExact(value.ToString(), "dd-MM-yyyy hh:mm:ss", enUS,
                               DateTimeStyles.None, out DateTime dateTime))
            {
                if (dateTime.Date < DateTime.Now.Date && dateTime.Date > Convert.ToDateTime("01/10/1950"))
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("Please select correct Date of Birth.");
            }
            else
            {
                return new ValidationResult("Date is incorrect.");
            }

        }
    }
}
