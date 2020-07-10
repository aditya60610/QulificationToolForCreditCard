using QulificationToolForCreditCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QulificationToolForCreditCard.Repository.Interface
{
    public interface ICardDetailsRepository
    {
        CardDetails GetByID(int creditCardId);
    }
}
