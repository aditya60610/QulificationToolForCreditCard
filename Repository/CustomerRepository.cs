using QulificationToolForCreditCard.Models;
using QulificationToolForCreditCard.Repository.Interface;
using System.Linq;

namespace QulificationToolForCreditCard.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CreditCardContext _context;

        public CustomerRepository()
        {
            _context = new CreditCardContext();
        }

        public CustomerRepository(CreditCardContext context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public bool Find(Customer customer)
        {
            IQueryable<Customer> result = _context.Customers.Where(x =>x.FirstName.Equals(customer.FirstName) && x.LastName.Equals(customer.LastName) && x.DOB.Date.Equals(customer.DOB.Date));
            return   result.Any() ? true : false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
