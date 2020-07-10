
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QulificationToolForCreditCard.Models
{
    public class CardDetails
    {
        [Key]
        public int CreditCardId { get; set; }

        [StringLength(50)]
        public string CardName { get; set; }

        public decimal APR { get; set; }
        public string Message { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
