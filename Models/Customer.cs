using QulificationToolForCreditCard.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QulificationToolForCreditCard.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage = "Characters are not allowed.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Characters are not allowed.")]
        public string LastName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [ValidateDate]
        public DateTime DOB { get; set; }

        [Column("Annual_Income")]
        [RegularExpression(@"^\d{0,8}(\.\d{1,4})?$", ErrorMessage = "Please Enter Proper Annual Income.")]
        [Display(Name = "Annual Income")]
        public decimal AnnualIncome { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public int CreditCardId { get; set; }

        [ForeignKey("CreditCardId")]
        public CardDetails CardDetails { get; set; }

        public Customer()
        {
            this.CreatedDateTime = DateTime.Now;
            this.ModifiedDateTime = DateTime.Now;
        }
    }
}
