using QulificationToolForCreditCard.Models;
using QulificationToolForCreditCard.Repository.Interface;

namespace QulificationToolForCreditCard.Repository
{
    public class CardDetailsRepository : ICardDetailsRepository
    {
        private readonly CreditCardContext _context;

        public CardDetailsRepository()
        {
            _context = new CreditCardContext();
        }

        public CardDetailsRepository(CreditCardContext context)
        {
            _context = context;
        }

        public CardDetails GetByID(int creditCardId)
        {
            return _context.CardDetails.Find(creditCardId);
        }
    }
}
